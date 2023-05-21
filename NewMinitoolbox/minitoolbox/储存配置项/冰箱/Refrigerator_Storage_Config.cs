using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using UnityEngine;

namespace minitoolbox.储存配置项.冰箱
{
    [HarmonyPatch(typeof(RefrigeratorConfig), "DoPostConfigureComplete")]
    public class Refrigerator_Storage_Config
    {
        private static void Postfix(GameObject go)
        {
            Storage storage = go.AddOrGet<Storage>();
            //冰箱储存容量
            storage.capacityKg = 冰箱.容量;
        }
    }
}
