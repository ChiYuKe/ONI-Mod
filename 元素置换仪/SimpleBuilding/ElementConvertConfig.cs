using System.Collections.Generic;
using TUNING;
using UnityEngine;

namespace ElementConvert.ElementConvertConfig
{
    public class ElementConvertConfig : IBuildingConfig
    {
        //这是一个指导意义的mod，同时也是我第一个建筑mod，有问题可以来【大叔追彩云】的频道(频道id：9qa754jb6h)找我(昵称：游手好闲）

        // 最好在自己的 ID 前加上一个独特的词，以避免与其他模组发生冲突
        public static string ID = "MyMod_ElementConvert";

        // 存储一些值以便以后轻松访问
        public static float NUMBER = 0.2f;


        // 一个 BuildingDef 持有关于我们建筑的配置
        public override BuildingDef CreateBuildingDef()
        {
            BuildingDef def = BuildingTemplates.CreateBuildingDef(
               id: ID,
               width: 3,
               height: 4,
               anim: "ElementConvert1_kanim", // 这是动画所在的文件夹的名称。 始终将 _kanim 添加到此末尾
               hitpoints: BUILDINGS.HITPOINTS.TIER2,//100
               construction_time: BUILDINGS.CONSTRUCTION_TIME_SECONDS.TIER2,//30s后建造完成
               construction_mass: BUILDINGS.CONSTRUCTION_MASS_KG.TIER6,//质量1200f
               construction_materials: MATERIALS.REFINED_METALS,//精炼金属
               melting_point: BUILDINGS.MELTING_POINT_KELVIN.TIER3,//熔点3200
               build_location_rule: BuildLocationRule.OnFloor,//只能在地面上
               decor: DECOR.BONUS.TIER1,
               noise: NOISE_POLLUTION.NONE,
               temperature_modification_mass_scale: NUMBER);

            // 
            def.OverheatTemperature = 473.15f;//过热温度
            def.RequiresPowerInput = true;
            def.EnergyConsumptionWhenActive = 1500f;
            def.SelfHeatKilowattsWhenActive = 20f;
            def.ViewMode = OverlayModes.Light.ID;
            def.AudioCategory = "Metal";

            return def;
        }


        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            //引用  ElementConvertTag 因为我把生产功能写在这个文件内的
            ElementConvertTag.ElementConvertTag.ElementConvertTag.ConfgiureRecipes();

            go.AddOrGet<DropAllWorkable>();
            go.AddOrGet<BuildingComplete>().isManuallyOperated = true;
            //复杂的制造可行
            Workable workable = go.AddOrGet<ComplexFabricatorWorkable>();

            //工作动画（复制人操作这个建筑时要覆盖的动画）
            workable.overrideAnims = new KAnimFile[]
            {
                //Assets.GetAnim("anim_interacts_phonobox_danceone_kanim"),
                //Assets.GetAnim("anim_interacts_phonobox_dancetwo_kanim"),
                //Assets.GetAnim("anim_interacts_metalrefinery_kanim")
                Assets.GetAnim("anim_interacts_orbital_research_station_kanim")
            };


            go.AddOrGet<ConduitConsumer>().capacityKG = 1000f;
            go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.IndustrialMachinery, false);


            ComplexFabricator complexFabricator = go.AddOrGet<ComplexFabricator>();
            //加热温度
            complexFabricator.heatedTemperature = 353.15f;
            //复制人操作
            complexFabricator.duplicantOperated = true;
            //侧屏样式   列表队列混合
            complexFabricator.sideScreenStyle = ComplexFabricatorSideScreen.StyleSetting.ListQueueHybrid; //ListQueueHybrid;
            //制造商成分状态管理器
            go.AddOrGet<FabricatorIngredientStatusManager>();
            //复制建筑设置
            go.AddOrGet<CopyBuildingSettings>();
            //创建复杂的制造商存储
            BuildingTemplates.CreateComplexFabricatorStorage(go, complexFabricator);
            //添加引用
            Prioritizable.AddRef(go);

        }

        // 这里只是给它配置一些小组件
        public override void DoPostConfigureComplete(GameObject go)
        {
            go.AddOrGet<LogicOperationalController>();
            go.AddOrGetDef<PoweredActiveController.Def>();
            SymbolOverrideControllerUtil.AddToPrefab(go);


            go.GetComponent<KPrefabID>().prefabSpawnFn += delegate (GameObject game_object)
            {
                ComplexFabricatorWorkable component = game_object.GetComponent<ComplexFabricatorWorkable>();
                //工人状态项   复制人状态物品 加工
                component.WorkerStatusItem = Db.Get().DuplicantStatusItems.Processing;
                //属性转换器  机械速度
                component.AttributeConverter = Db.Get().AttributeConverters.MachinerySpeed;
                //属性经验乘数  属性调平   部分日经验
                component.AttributeExperienceMultiplier = DUPLICANTSTATS.ATTRIBUTE_LEVELING.PART_DAY_EXPERIENCE;
                //技能经验技能组  技能组   技术面
                component.SkillExperienceSkillGroup = Db.Get().SkillGroups.Technicals.Id;
                //技能经验乘数   技能  部分日经验
                component.SkillExperienceMultiplier = SKILLS.PART_DAY_EXPERIENCE;
            };

        }

    }

}
    

