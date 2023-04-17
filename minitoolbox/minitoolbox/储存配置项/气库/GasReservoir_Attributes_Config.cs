using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.气库
{
    [HarmonyPatch(typeof(GasReservoirConfig), "CreateBuildingDef")]
    public class GasReservoir_Attributes_Config
    {
        private static void Postfix(GasReservoirConfig __instance, ref BuildingDef __result)
        {
            //气库360度旋转
            __result.PermittedRotations = PermittedRotations.R360;
            //建立位置规则
            __result.BuildLocationRule = BuildLocationRule.Anywhere;
            //气库是否需要地基
            __result.ContinuouslyCheckFoundation = 气库.地基;
        }
        public static void Postfix(ref BuildingDef __result)
        {
            //气库是否会过热
            __result.Overheatable = 气库.过热;
        }
    }
}
