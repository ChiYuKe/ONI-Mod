using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.建筑配置项.金属精炼器
{
    [HarmonyPatch(typeof(MetalRefineryConfig), "ConfigureBuildingTemplate")]
    public class MetalRefinery
    {
        public static void Postfix(MetalRefineryConfig __instance,ref GameObject go)
        {
            //金属精炼器的容量
            float refineryWaterCapacity = 金属精炼器.容量;
            //金属精炼器是否会加热冷却剂，默认是true
            bool fudge = 金属精炼器.加热;
            LiquidCooledRefinery liquidCooledRefinery = go.AddOrGet<LiquidCooledRefinery>();
            //游戏里是加热液体0.8f
            liquidCooledRefinery.thermalFudge = (fudge ? 0.8f : 0f);
            ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
            conduitConsumer.capacityKG = refineryWaterCapacity;
        }
        private static void Postfix(GameObject go, Tag prefab_tag)
        {
            //是否需要复制人去操作
            go.AddOrGet<ComplexFabricator>().duplicantOperated = 金属精炼器.操作;
        }

    }
}
