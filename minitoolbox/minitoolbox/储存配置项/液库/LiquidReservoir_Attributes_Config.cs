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

namespace minitoolbox.储存配置项.液库
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
            __result.ContinuouslyCheckFoundation = 液库.地基;
            //是否会过热
            __result.Overheatable = 液库.过热;
            Debug.LogFormat("MinBox::已调整液库容量为：{0} kg,液库是否需要地基：{1},液库是否会过热：{2}", 液库.容量, 液库.地基, 液库.过热);
        }

    }

   
}
