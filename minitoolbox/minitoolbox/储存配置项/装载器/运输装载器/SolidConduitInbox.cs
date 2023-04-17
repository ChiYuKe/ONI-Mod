using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.储存配置项.装载器.运输装载器
{
    [HarmonyPatch(typeof(SolidConduitInboxConfig), "DoPostConfigureComplete")]
    public class SolidConduitInbox
    {
        public static void Postfix(SolidConduitInboxConfig __instance, ref GameObject go)
        {
            float SolidConduitInboxCapacity = 运输装载器.容量;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = SolidConduitInboxCapacity;
        }
    }
}
