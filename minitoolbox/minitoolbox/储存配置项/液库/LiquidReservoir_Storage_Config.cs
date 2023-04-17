using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.储存配置项.液库
{
    [HarmonyPatch(typeof(LiquidReservoirConfig), "ConfigureBuildingTemplate")]
    public class LiquidReservoir_Storage_Config
    {
        private static void Postfix(LiquidReservoirConfig __instance, ref GameObject go)
        {
            //液库容量以及容量减少规则
            Storage storage = BuildingTemplates.CreateDefaultStorage(go, false);
            //液库容量
            storage.capacityKg = 液库.容量;
            storage.SetDefaultStoredItemModifiers(Storage.StandardInsulatedStorage);
            storage.allowUIItemRemoval = true;
            ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
            conduitConsumer.capacityKG = storage.capacityKg;
        }
    }
}
