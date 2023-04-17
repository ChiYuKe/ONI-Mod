using System.Collections.Generic;
using TUNING;
using UnityEngine;
using static STRINGS.DUPLICANTS.CHORES;

namespace ElementConvert.ElementConvertConfig
{
    public class NeutronMakeLiquidConfig : IBuildingConfig
    {
        //这是一个指导意义的mod，同时也是我第一个建筑mod，有问题可以来【大叔追彩云】的频道(频道id：9qa754jb6h)找我(昵称：游手好闲）

        // 最好在自己的 ID 前加上一个独特的词，以避免与其他模组发生冲突
        public static string ID = "MyMod_NeutronMakeLiquid";

        // 存储一些值以便以后轻松访问
        public static float NUMBER = 0.2f;

        public override string[] GetDlcIds()
        {
            return DlcManager.AVAILABLE_EXPANSION1_ONLY;
        }

        // 一个 BuildingDef 持有关于我们建筑的配置
        public override BuildingDef CreateBuildingDef()
        {
            BuildingDef def = BuildingTemplates.CreateBuildingDef(
               id: ID,
               width: 3,
               height: 3, 
               anim: "medicine_nuclear_kanim", // 这是动画所在的文件夹的名称。 始终将 _kanim 添加到此末尾NeutronMakeLiquid1_kanim
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
            def.EnergyConsumptionWhenActive = 1200f;
            def.SelfHeatKilowattsWhenActive = 20f;
            def.ViewMode = OverlayModes.Light.ID;
            def.AudioCategory = "HollowMetal";
            def.AudioSize = "large";


            def.OutputConduitType = ConduitType.Liquid;
            def.UtilityOutputOffset = outPipeOffset;


            return def; 
        }


        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.IndustrialMachinery, false);
            //

            //
            UraniumCentrifuge centrifuge = go.AddOrGet<UraniumCentrifuge>();
            //创建合成的制造商存储
            BuildingTemplates.CreateComplexFabricatorStorage(go, centrifuge);
            centrifuge.outStorage.capacityKg = 2000f;
            //储存生产的
            centrifuge.storeProduced = true;
            //复杂制造商宽屏
            centrifuge.sideScreenStyle = ComplexFabricatorSideScreen.StyleSetting.ListQueueHybrid;
            //制造商成分状态管理器
            go.AddOrGet<FabricatorIngredientStatusManager>();
            //复制人操作
            centrifuge.duplicantOperated = true;
            //

            ConduitDispenser dispenser = go.AddOrGet<ConduitDispenser>();
            dispenser.alwaysDispense = true;
            dispenser.conduitType = ConduitType.Liquid;
            dispenser.storage = centrifuge.outStorage;

            //

            ComplexRecipe.RecipeElement[] inputs = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Unobtanium).tag, 0.01f)
            };
            ComplexRecipe.RecipeElement[] outputs = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Water).tag, 500f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false),
                new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Algae).tag, 2f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false)
                
            };
            string id = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", inputs, outputs);
            ComplexRecipe complexRecipe = new ComplexRecipe(id, inputs, outputs);
            complexRecipe.time = 10f;
            complexRecipe.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            complexRecipe.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Unobtanium).name, ElementLoader.FindElementByHash(SimHashes.Water).name);
            complexRecipe.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            Prioritizable.AddRef(go);
            //
        }




        // 这里只是给它配置一些小组件
        public override void DoPostConfigureComplete(GameObject go)
        {
            go.AddOrGet<LogicOperationalController>();
            go.AddOrGetDef<PoweredActiveController.Def>();


            SymbolOverrideControllerUtil.AddToPrefab(go);

        }



        public static readonly CellOffset outPipeOffset = new CellOffset(1, 0);

        private static readonly List<Storage.StoredItemModifier> storedItemModifiers = new List<Storage.StoredItemModifier>
        {
            Storage.StoredItemModifier.Hide,//隐藏
            Storage.StoredItemModifier.Preserve,//保存
            Storage.StoredItemModifier.Insulate,//隔离
        };
    }
}
    

