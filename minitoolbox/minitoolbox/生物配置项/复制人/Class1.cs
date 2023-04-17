using HarmonyLib;
using PeterHan.PLib.Options;
using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;
using static TUNING.FOOD;

namespace minitoolbox.生物配置项.食物
{
    [HarmonyPatch(typeof(Db), "Initialize")]
    internal class TheInstanceheats
    {
        // 气压服
        private static void Prefix(Db __instance)
        {

            bool ATMOSUIT = SingletonOptions<ConfigurationItem>.Instance.super_atmosuit;
            TUNING.EQUIPMENT.SUITS.ATMOSUIT_DIGGING = ATMOSUIT ? 200 : 10 ;//挖掘
            TUNING.EQUIPMENT.SUITS.ATMOSUIT_INSULATION = ATMOSUIT ? 3000 : 50;//隔热度
            TUNING.EQUIPMENT.SUITS.ATMOSUIT_SCALDING = ATMOSUIT ? 6000 : 1000;//温度伤害
            TUNING.EQUIPMENT.SUITS.ATMOSUIT_ATHLETICS = ATMOSUIT ? 100 : -6;//速度
            TUNING.EQUIPMENT.SUITS.ATMOSUIT_THERMAL_CONDUCTIVITY_BARRIER = ATMOSUIT ? 10f : 0.2f;//隔热厚度
        }

    }
}
