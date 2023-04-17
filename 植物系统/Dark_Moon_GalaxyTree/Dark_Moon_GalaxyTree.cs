using System;
using System.Collections.Generic;
using STRINGS;
using UnityEngine;

namespace Dark_Moon_GalaxyTree
{
    public class Dark_Moon_GalaxyTree : StateMachineComponent<Dark_Moon_GalaxyTree.StatesInstance>
    {
        protected override void OnSpawn()
        {
            base.OnSpawn();
            base.smi.Get<KBatchedAnimController>().randomiseLoopedOffset = true;//该属性控制对象在循环播放时是否随机偏移。
            base.smi.master.elementEmitter.SetEmitting(false);//设置了对象的 master的 elementEmitter组件不发射。
            base.smi.master.elementConsumer.EnableConsumption(false);//禁用了对象的elementConsumer组件的消费。
            base.smi.StartSM();//这可能会启动或初始化与对象相关的某种状态机或模拟。
        }


        protected void DestroySelf(object callbackParam)
        {
            CreatureHelpers.DeselectCreature(base.gameObject);
            Util.KDestroyGameObject(base.gameObject);
        }


        public Notification CreateDeathNotification()
        {
            return new Notification(CREATURES.STATUSITEMS.PLANTDEATH.NOTIFICATION, NotificationType.Bad, (List<Notification> notificationList, object data) => CREATURES.STATUSITEMS.PLANTDEATH.NOTIFICATION_TOOLTIP + notificationList.ReduceMessages(false), "/t• " + base.gameObject.GetProperName(), true, 0f, null, null, null, true, false);
        }


        [MyCmpReq]
        private Crop crop;


        [MyCmpReq]
        private WiltCondition wiltCondition;

        [MyCmpReq]
        private Growing growing;


        [MyCmpReq]
        private ReceptacleMonitor rm;


        [MyCmpReq]
        private Harvestable harvestable;


        [MyCmpReq]
        private ElementEmitter elementEmitter;


        [MyCmpReq]
        private ElementConsumer elementConsumer;


        public class StatesInstance : GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.GameInstance
        {

            public StatesInstance(Dark_Moon_GalaxyTree master) : base(master)
            {
            }

            //IsOld 方法用来判断当前状态是否为老年状态，如果返回值为 true，则该状态为老年状态，否则不是老年状态。
            public bool IsOld()
            {
                return (double)base.master.growing.PercentOldAge() > 0.5;
            }
        }


        public class AnimSet
        {

            public const string grow = "grow";


            public const string grow_pst = "grow_pst";


            public const string idle_full = "idle_full";


            public const string wilt_pre = "wilt_pre";


            public const string wilt = "wilt";


            public const string wilt_pst = "wilt_pst";


            public const string harvest = "harvest";
        }


        public class States : GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree>
        {

            public override void InitializeStates(out StateMachine.BaseState defaultState)
            {
                base.serializable = StateMachine.SerializeType.Both_DEPRECATED;
                defaultState = this.Alive;
                LocString name = CREATURES.STATUSITEMS.DEAD.NAME;
                LocString tooltip = CREATURES.STATUSITEMS.DEAD.TOOLTIP;
                StatusItemCategory main = Db.Get().StatusItemCategories.Main;
                this.Dead.ToggleStatusItem(name, tooltip, string.Empty, StatusItem.IconType.Info, (NotificationType)0, false, OverlayModes.None.ID, 0, null, null, main).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    if (smi.master.rm.Replanted && !smi.master.GetComponent<KPrefabID>().HasTag(GameTags.Uprooted))
                    {
                        smi.master.gameObject.AddOrGet<Notifier>().Add(smi.master.CreateDeathNotification(), "");
                    }
                    GameUtil.KInstantiate(Assets.GetPrefab(EffectConfigs.PlantDeathId), smi.master.transform.GetPosition(), Grid.SceneLayer.FXFront, null, 0).SetActive(true);
                    if (smi.master.harvestable != null && smi.master.harvestable.CanBeHarvested && GameScheduler.Instance != null)
                    {
                        GameScheduler.Instance.Schedule("SpawnFruit", 0.2f, new Action<object>(smi.master.crop.SpawnConfiguredFruit), null, null);
                    }
                    smi.master.Trigger(1623392196, null);
                    smi.master.GetComponent<KBatchedAnimController>().StopAndClear();
                    UnityEngine.Object.Destroy(smi.master.GetComponent<KBatchedAnimController>());
                    smi.Schedule(0.5f, new Action<object>(smi.master.DestroySelf), null);
                });
                this.Alive.InitializeStates(this.masterTarget, this.Dead).DefaultState(this.Alive.Idle).ToggleComponent<Growing>(false);
                this.Alive.Idle.Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementConsumer.EnableConsumption(true);
                }).EventTransition(GameHashes.Wilt, this.Alive.WiltingPre, (Dark_Moon_GalaxyTree.StatesInstance smi) => smi.master.wiltCondition.IsWilting()).EventTransition(GameHashes.Grow, this.Alive.PreFruiting, (Dark_Moon_GalaxyTree.StatesInstance smi) => smi.master.growing.ReachedNextHarvest()).PlayAnim("grow", KAnim.PlayMode.Loop).Exit(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementConsumer.EnableConsumption(false);
                });
                this.Alive.PreFruiting.PlayAnim("grow", KAnim.PlayMode.Once).EventTransition(GameHashes.AnimQueueComplete, this.Alive.Fruiting, null);
                this.Alive.FruitingLost.Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.harvestable.SetCanBeHarvested(false);
                }).GoTo(this.Alive.Idle);
                this.Alive.WiltingPre.QueueAnim("wilt_pre", false, null).OnAnimQueueComplete(this.Alive.Wilting);
                this.Alive.Wilting.PlayAnim("wilt", KAnim.PlayMode.Loop).EventTransition(GameHashes.WiltRecover, this.Alive.WiltingPst, (Dark_Moon_GalaxyTree.StatesInstance smi) => !smi.master.wiltCondition.IsWilting()).EventTransition(GameHashes.Harvest, this.Alive.Harvest, null);
                this.Alive.WiltingPst.PlayAnim("wilt", KAnim.PlayMode.Once).OnAnimQueueComplete(this.Alive.Idle);
                this.Alive.Fruiting.DefaultState(this.Alive.Fruiting.FruitingIdle).EventTransition(GameHashes.Wilt, this.Alive.WiltingPre, null).EventTransition(GameHashes.Harvest, this.Alive.Harvest, null).EventTransition(GameHashes.Grow, this.Alive.FruitingLost, (Dark_Moon_GalaxyTree.StatesInstance smi) => !smi.master.growing.ReachedNextHarvest());
                this.Alive.Fruiting.FruitingIdle.PlayAnim("idle_full", KAnim.PlayMode.Loop).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.harvestable.SetCanBeHarvested(true);
                }).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementConsumer.EnableConsumption(true);
                }).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementEmitter.SetEmitting(true);
                }).Update("fruiting_idle", delegate (Dark_Moon_GalaxyTree.StatesInstance smi, float dt)
                {
                    if (!smi.IsOld())
                    {
                        return;
                    }
                    smi.GoTo(this.Alive.Fruiting.FruitingOld);
                }, UpdateRate.SIM_4000ms, false).Exit(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementEmitter.SetEmitting(false);
                }).Exit(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.elementConsumer.EnableConsumption(false);
                });
                this.Alive.Fruiting.FruitingOld.PlayAnim("wilt", KAnim.PlayMode.Loop).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    smi.master.harvestable.SetCanBeHarvested(true);
                }).Update("fruiting_old", delegate (Dark_Moon_GalaxyTree.StatesInstance smi, float dt)
                {
                    if (smi.IsOld())
                    {
                        return;
                    }
                    smi.GoTo(this.Alive.Fruiting.FruitingIdle);
                }, UpdateRate.SIM_4000ms, false);
                this.Alive.Harvest.PlayAnim("harvest", KAnim.PlayMode.Once).Enter(delegate (Dark_Moon_GalaxyTree.StatesInstance smi)
                {
                    if (GameScheduler.Instance == null || smi.master == null)
                    {
                        return;
                    }
                    GameScheduler.Instance.Schedule("SpawnFruit", 0.2f, new Action<object>(smi.master.crop.SpawnConfiguredFruit), null, null);
                    smi.master.harvestable.SetCanBeHarvested(false);
                }).OnAnimQueueComplete(this.Alive.Idle);
            }


            public Dark_Moon_GalaxyTree.States.AliveStates Alive;


            public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State Dead;


            public class AliveStates : GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.PlantAliveSubState
            {
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State Idle;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State PreFruiting;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State FruitingLost;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State WiltingPre;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State Wilting;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State WiltingPst;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State Harvest;
                public Dark_Moon_GalaxyTree.States.FruitingState Fruiting;
            }

            public class FruitingState : GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State
            {
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State FruitingIdle;
                public GameStateMachine<Dark_Moon_GalaxyTree.States, Dark_Moon_GalaxyTree.StatesInstance, Dark_Moon_GalaxyTree, object>.State FruitingOld;
            }
        }
    }
}
