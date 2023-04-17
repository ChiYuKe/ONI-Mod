using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.minitool_boox.Refrigerator_Changes
{
    [HarmonyPatch(typeof(RefrigeratorConfig), "DoPostConfigureComplete")]
    public class Refrigerator_Storage_Config
    {
        private static void Postfix(GameObject go)
        {
            Storage storage = go.AddOrGet<Storage>();
            //冰箱储存容量
            storage.capacityKg = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Capacity;
        }
    }
}
