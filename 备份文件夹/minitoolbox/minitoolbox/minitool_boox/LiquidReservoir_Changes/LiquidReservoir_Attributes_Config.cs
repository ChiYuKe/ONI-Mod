using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.minitool_boox.LiquidReservoir_Changes
{
    [HarmonyPatch(typeof(LiquidReservoirConfig), "CreateBuildingDef")]
    public class LiquidReservoir_Attributes_Config
    {
        private static void Postfix(LiquidReservoirConfig __instance, ref BuildingDef __result)
        {
            __result.PermittedRotations = PermittedRotations.R360;
            //建立位置规则
            __result.BuildLocationRule = BuildLocationRule.Anywhere;
            //液库是否需要地基
            __result.ContinuouslyCheckFoundation = SingletonOptions<ConfigurationItem>.Instance.LiquidReservoir_foundation ? false: true;
            //是否会过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.LiquidReservoir_Overheat ? false : true;
            //偏移量
            __result.UtilityInputOffset = new CellOffset(0, 2);
        }

    }

   
}
