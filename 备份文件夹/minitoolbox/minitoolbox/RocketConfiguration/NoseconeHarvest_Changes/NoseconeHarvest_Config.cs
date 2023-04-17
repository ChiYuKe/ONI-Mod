using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.RocketConfiguration.NoseconeHarvest_Changes
{
    //火箭钻头
    //TODO 暂时先这么写，以后会添加局内的滑块调整来调节钻头的容量
    [HarmonyPatch(typeof(NoseconeHarvestConfig), "ConfigureBuildingTemplate")]
    public class NoseconeHarvest_Config
    {
        private static void Postfix(NoseconeHarvestConfig __instance, ref GameObject go)
        {
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = SingletonOptions<ConfigurationItem>.Instance.NoseconeHarvest_Capacity;

            ManualDeliveryKG manualDeliveryKG = go.AddOrGet<ManualDeliveryKG>();
            manualDeliveryKG.capacity = storage.capacityKg;
            manualDeliveryKG.refillMass = storage.capacityKg;

        }

    }
}
