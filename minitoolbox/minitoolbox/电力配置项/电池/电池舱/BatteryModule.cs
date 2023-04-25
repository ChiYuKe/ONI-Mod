using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.电力配置项.电池.电池舱
{
    [HarmonyPatch(typeof(BatteryModuleConfig), "DoPostConfigureComplete")]
    public class BatteryModule
    {
        public static void Postfix(GameObject go)
        {
            ModuleBattery moduleBattery = go.AddOrGet<ModuleBattery>();
            moduleBattery.capacity = 电池舱.电池容量;
            moduleBattery.joulesLostPerSecond = 电池舱.电源损耗;
            Debug.LogFormat("已调整电池舱电池容量为：{0}，电池舱电源损耗{1}",电池舱.电池容量,电池舱.电源损耗);
        }
    }
}
