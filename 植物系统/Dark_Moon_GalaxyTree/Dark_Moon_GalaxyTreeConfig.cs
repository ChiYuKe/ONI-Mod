using System;
using System.Collections.Generic;
using STRINGS;
using TUNING;
using UnityEngine;

namespace Dark_Moon_GalaxyTree
{
    public class Dark_Moon_GalaxyTreeConfig : IEntityConfig
    {

        //低温致死温度 低温警告 高温警告 高温致死温度
        //安全元素
        //压力敏感  致死压力低 压力警告低 作物_id 可以淹死 可以修补 需要实心砖 应该变老..最大年龄 最小辐射 最大辐射 基本特征ID  基本特征名称
        //果子输出元素  0.01kd的氧气   最小输出温度0  使用实体温度  存储输出  输出元素偏移量x,y  病重 添加的疾病IDx  添加的疾病计数 活跃
        //
        public GameObject CreatePrefab()
        {
            GameObject gameObject = EntityTemplates.CreatePlacedEntity("Dark_Moon_GalaxyTree", Strings.NAME3, Strings.DESCRIPTION3, 1f, Assets.GetAnim("Dark_Moon_GalaxyTree_kanim"), "idle_loop", Grid.SceneLayer.BuildingFront, 1, 2, new EffectorValues
            {
                amount = 25,
                radius = 6
            }, default(EffectorValues), SimHashes.Creature, null, 350f);
            EntityTemplates.ExtendEntityToBasicPlant(gameObject, 253.15f, 293.15f, 373.15f, 383.15f, new SimHashes[]
            {
                SimHashes.CarbonDioxide
            }, false, 0f, 0.1f, Dark_Moon_GalaxyFruitConfig.Id, true, true, true, true, 2400f, 0f, 2500f, "Dark_Moon_Galaxy", Strings.NAME3);
            gameObject.AddOrGet<Dark_Moon_GalaxyTree>();//动画组件

            ElementConsumer elementConsumer = gameObject.AddOrGet<ElementConsumer>();
            elementConsumer.elementToConsume = SimHashes.CarbonDioxide;
            elementConsumer.consumptionRate = 0.005f;

            ElementEmitter elementEmitter = gameObject.AddOrGet<ElementEmitter>();
            elementEmitter.outputElement = new ElementConverter.OutputElement(0.01f, SimHashes.Oxygen, 0f, true, false, 0f, 2f, 1f, byte.MaxValue, 0, true);
            elementEmitter.maxPressure = 0.8f;

            GameObject plant = gameObject;
            SeedProducer.ProductionType productionType = SeedProducer.ProductionType.Harvest;
            string id = "Dark_Moon_GalaxyTreeSeed";
            string name = UI.FormatAsLink(Strings.SEEDNAME, "Dark_Moon_GalaxyTree");
            string seedDescription = Dark_Moon_GalaxyTreeConfig.SeedDescription;
            KAnimFile anim = Assets.GetAnim("Dark_Moon_GalaxySeed_kanim");//种子
            string initialAnim = "object";
            int numberOfSeeds = 0;
            List<Tag> list = new List<Tag>();
            list.Add(GameTags.CropSeed);
            SingleEntityReceptacle.ReceptacleDirection planterDirection = SingleEntityReceptacle.ReceptacleDirection.Top;
            string domesticatedDescription = STRINGS.CREATURES.SPECIES.JUNGLEGASPLANT.DOMESTICATEDDESC;
            EntityTemplates.CreateAndRegisterPreviewForPlant(EntityTemplates.CreateAndRegisterSeedForPlant(plant, productionType, id, name, seedDescription, anim, initialAnim, numberOfSeeds, list, planterDirection, default(Tag), 7, domesticatedDescription, EntityTemplates.CollisionShape.CIRCLE, 0.33f, 0.33f, null, "", false), "PalmeraTree_preview", Assets.GetAnim("Dark_Moon_GalaxyTree_kanim"), "place", 1, 2);
            SoundEventVolumeCache.instance.AddVolume("bristleblossom_kanim", "PrickleFlower_harvest", NOISE_POLLUTION.CREATURES.TIER1);
            return gameObject;
        }

        public void OnPrefabInit(GameObject inst)
        {
        }

        public void OnSpawn(GameObject inst)
        {
        }

        public string[] GetDlcIds()
        {
            return DlcManager.AVAILABLE_ALL_VERSIONS;
        }


        public const string Id = "Dark_Moon_GalaxyTree";
        public const string SeedId = "Dark_Moon_GalaxyTreeSeed";
        public static string DomesticatedDescription = "这是一株大量吃着二氧化碳的 " + UI.FormatAsLink("植物", "植物") + " 他们的果子会散发出氧气";
        public static string SeedDescription = string.Concat(new string[]
        {
            "这个 ",
            UI.FormatAsLink("种子", "植物"),
            " 来自",
            UI.FormatAsLink(Strings.NAME3, "Dark_Moon_GalaxyTree"),
            "."
        });


        private const string AnimName = "Dark_Moon_GalaxyTree_kanim";
        private const string AnimNameSeed = "Dark_Moon_GalaxySeed_kanim";
    }
}
