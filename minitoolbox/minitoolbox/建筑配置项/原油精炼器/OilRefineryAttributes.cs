using KSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.建筑配置项.原油精炼器
{
    [SerializationConfig(MemberSerialization.OptIn)]
    public class OilRefineryAttributes : StateMachineComponent<OilRefineryAttributes.StatesInstance>
    {
        protected override void OnSpawn()
        {
            base.Subscribe<OilRefineryAttributes>(-1697596308, OilRefineryAttributes.OnStorageChangedDelegate);
            KBatchedAnimController component = base.GetComponent<KBatchedAnimController>();
            this.meter = new MeterController(component, "meter_target", "meter", Meter.Offset.Infront, Grid.SceneLayer.NoLayer, Vector3.zero, null);
            base.smi.StartSM();
            this.maxSrcMass = base.GetComponent<ConduitConsumer>().capacityKG;
        }
        private void OnStorageChanged(object data)
        {
            float positionPercent = Mathf.Clamp01(this.storage.GetMassAvailable(SimHashes.CrudeOil) / this.maxSrcMass);
            this.meter.SetPositionPercent(positionPercent);
        }
        private static bool UpdateStateCb(int cell, object data)
        {
            OilRefineryAttributes automaticOilRefinery = data as OilRefineryAttributes;
            bool isGas = Grid.Element[cell].IsGas;
            if (isGas)
            {
                automaticOilRefinery.cellCount += 1f;
                automaticOilRefinery.envPressure += Grid.Mass[cell];
            }
            return true;
        }

        [SerializeField]
        public float overpressureWarningMass = 4.5f;

        [SerializeField]
        public float overpressureMass = 5f;

        private float maxSrcMass;

        private float envPressure;

        private float cellCount;

        [MyCmpGet]
        private Storage storage;

        [MyCmpReq]
        private Operational operational;

        private MeterController meter;

        private static readonly EventSystem.IntraObjectHandler<OilRefineryAttributes> OnStorageChangedDelegate = new EventSystem.IntraObjectHandler<OilRefineryAttributes>(delegate (OilRefineryAttributes component, object data)
        {
            component.OnStorageChanged(data);
        });

        public class StatesInstance : GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.GameInstance
        {
            public StatesInstance(OilRefineryAttributes smi) : base(smi)
            {
            }
        }

        public class States : GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes>
        {
            public override void InitializeStates(out StateMachine.BaseState default_state)
            {
                default_state = this.off;
                this.off.PlayAnim("off").EventTransition(GameHashes.OperationalChanged, this.on, (OilRefineryAttributes.StatesInstance smi) => smi.master.operational.IsOperational);
                this.on.PlayAnim("on").EventTransition(GameHashes.OperationalChanged, this.off, (OilRefineryAttributes.StatesInstance smi) => !smi.master.operational.IsOperational).DefaultState(this.on.waiting);
                this.on.waiting.EventTransition(GameHashes.OnStorageChange, this.on.working_pre, (OilRefineryAttributes.StatesInstance smi) => smi.master.GetComponent<ElementConverter>().HasEnoughMassToStartConverting());
                this.on.working_pre.PlayAnim("working_pre").OnAnimQueueComplete(this.on.working);
                this.on.working.Enter(delegate (OilRefineryAttributes.StatesInstance smi)
                {
                    smi.master.operational.SetActive(true, false);
                }).QueueAnim("working_loop", true, null).EventTransition(GameHashes.OnStorageChange, this.on.working_pst,
                (OilRefineryAttributes.StatesInstance smi) => !smi.master.GetComponent<ElementConverter>
                ().CanConvertAtAll()).Exit(delegate (OilRefineryAttributes.StatesInstance smi)
                {
                    smi.master.operational.SetActive(false, false);
                });
                this.on.working_pst.PlayAnim("working_pst").OnAnimQueueComplete(this.on.waiting);
            }

            public GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State off;

            public OilRefineryAttributes.States.OnStates on;

            public class OnStates : GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State
            {
                public GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State waiting;

                public GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State working_pre;

                public GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State working;

                public GameStateMachine<OilRefineryAttributes.States, OilRefineryAttributes.StatesInstance, OilRefineryAttributes, object>.State working_pst;
            }
        }
    }
}
