using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.储存配置项.装载器.运输存放器
{
    [HarmonyPatch(typeof(SolidConduitOutboxConfig), "ConfigureBuildingTemplate")]
    public class SolidConduitOutbox
    {
        
        private static void Postfix(SolidConduitOutboxConfig __instance, ref GameObject go)
        {
            float capacity = 运输存放器.容量;
            Storage storage = BuildingTemplates.CreateDefaultStorage(go, false);
            storage.capacityKg = capacity;
            go.AddOrGet<SolidConduitConsumer>().capacityKG = capacity;
            Debug.LogFormat("MinBox::已调整运输存放器容量为：{0} kg", 运输存放器.容量);
        }
    }
}
