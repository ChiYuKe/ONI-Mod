using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.minitool_boox.GasReservoir_Changes
{
    [HarmonyPatch(typeof(GasReservoirConfig), "ConfigureBuildingTemplate")]
    public class GasReservoir_Storage_Config
    {
        private static void Postfix(GasReservoirConfig __instance, ref GameObject go)
        {
            Storage storage = BuildingTemplates.CreateDefaultStorage(go, false);
            //气库容量
            storage.capacityKg = SingletonOptions<ConfigurationItem>.Instance.GasReservoir_Capacity;
            storage.SetDefaultStoredItemModifiers(Storage.StandardInsulatedStorage);
            storage.allowUIItemRemoval = true;
            ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
            conduitConsumer.capacityKG = storage.capacityKg;
        }
    }
}
