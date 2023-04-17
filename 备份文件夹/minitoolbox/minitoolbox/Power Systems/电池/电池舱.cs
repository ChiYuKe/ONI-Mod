using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.Power_Systems.电池
{
    [HarmonyPatch(typeof(BatteryModuleConfig), "DoPostConfigureComplete")]
    public class 电池舱
    {
        public static void Postfix(GameObject go)
        {
            ModuleBattery moduleBattery = go.AddOrGet<ModuleBattery>();
            moduleBattery.capacity = SingletonOptions<ConfigurationItem>.Instance.电池舱容量 * 1000f;
            moduleBattery.joulesLostPerSecond = SingletonOptions<ConfigurationItem>.Instance.电池舱 ? 0f : 0.6666667f;
        }
    }
}
