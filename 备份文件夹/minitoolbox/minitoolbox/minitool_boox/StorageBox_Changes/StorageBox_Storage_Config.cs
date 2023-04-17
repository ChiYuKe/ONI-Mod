using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.minitool_boox.StorageBox_Changes
{
    [HarmonyPatch(typeof(StorageLockerConfig), "DoPostConfigureComplete")]
    public class StorageBox_Storage_Config
    {
        private static void Postfix(GameObject go)
        {
            //储物箱容量
            go.AddOrGet<Storage>().capacityKg = SingletonOptions<ConfigurationItem>.Instance.StorageBox_Capacity;
        }
    }
}
