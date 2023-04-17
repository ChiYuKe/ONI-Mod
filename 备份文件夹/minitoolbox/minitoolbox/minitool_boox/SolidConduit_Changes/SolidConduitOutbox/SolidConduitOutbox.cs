using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.minitool_boox.SolidConduit_Changes.SolidConduitOutbox
{
    [HarmonyPatch(typeof(SolidConduitOutboxConfig), "ConfigureBuildingTemplate")]
    public class SolidConduitOutbox
    {
        private static void Postfix(SolidConduitOutboxConfig __instance, ref GameObject go)
        {
            Storage storage = BuildingTemplates.CreateDefaultStorage(go, false);
            storage.capacityKg = SingletonOptions<ConfigurationItem>.Instance.SolidConduitOutbox_Capacity;
            go.AddOrGet<SolidConduitConsumer>().capacityKG = SingletonOptions<ConfigurationItem>.Instance.SolidConduitOutbox_Capacity;
        }
    }
}
