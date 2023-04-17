using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.minitool_boox.SolidConduit_Changes.SolidConduitInbox
{
    [HarmonyPatch(typeof(SolidConduitInboxConfig), "DoPostConfigureComplete")]
    public class SolidConduitInbox
    {
        public static void Postfix(SolidConduitInboxConfig __instance, ref GameObject go)
        {
            float SolidConduitInboxCapacity = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Capacity;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = SolidConduitInboxCapacity;
        }
    }
}
