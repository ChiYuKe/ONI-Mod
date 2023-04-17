using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Can_Be_Anywhere
{
    [HarmonyPatch(typeof(WireRefinedHighWattageConfig), "CreateBuildingDef")]
    internal class WireRefinedHighWattage_Config
    {
        public static void Postfix(BuildingDef __result)
        {
            __result.BuildLocationRule = BuildLocationRule.Anywhere;
            __result.ContinuouslyCheckFoundation = false;
            __result.ObjectLayer = ObjectLayer.Wire;
            __result.BaseDecor = __result.BaseDecor = SingletonOptions<Config>.Instance.WireRefinedHighWattage_BaseDecor;
            __result.BaseDecorRadius = SingletonOptions<Config>.Instance.WireRefinedHighWattage_BaseDecorRadius;
            Debug.Log("高负荷导线加载成功");

        }
    }
}
