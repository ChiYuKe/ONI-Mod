using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.储存配置项.气库
{
    [HarmonyPatch(typeof(GasReservoirConfig), "ConfigureBuildingTemplate")]
    public class GasReservoir_Storage_Config
    {
        private static void Postfix(GasReservoirConfig __instance, ref GameObject go)
        {
            Storage storage = BuildingTemplates.CreateDefaultStorage(go, false);
            //气库容量
            storage.capacityKg = 气库.容量;
            storage.SetDefaultStoredItemModifiers(Storage.StandardInsulatedStorage);
            storage.allowUIItemRemoval = true;
            ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
            conduitConsumer.capacityKG = storage.capacityKg;
        }
    }
}
