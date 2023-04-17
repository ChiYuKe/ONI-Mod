using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.储存配置项.储存箱
{
    [HarmonyPatch(typeof(StorageLockerConfig), "DoPostConfigureComplete")]
    public class StorageBox_Storage_Config
    {
        private static void Postfix(GameObject go)
        {
            //储物箱容量
            go.AddOrGet<Storage>().capacityKg = 储存箱.容量;
        }
    }
}
