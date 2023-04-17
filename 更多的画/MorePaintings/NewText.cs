using System;
using HarmonyLib;
using Database;
using static TUNING.METEORS;
using System.Reflection;

namespace more_paintings
{
    internal class NewText
    {
        [HarmonyPatch(typeof(BuildingFacades), MethodType.Constructor, new Type[]
        {
            typeof(ResourceSet)
        })]
        public static class GeneratedBuildings_LoadGeneratedBuildings_Patch
        {
            public static void Postfix(BuildingFacades __instance)
            {
                __instance.Add("paofu", "飞鱼床", "描述", PermitRarity.Universal, "LuxuryBed", "a_pu_kanim", null);
                __instance.Add("vanilla", "香草餐桌", "描述", PermitRarity.Universal, "DiningTable", "vanilla_kanim", null);
                __instance.Add("xiangz", "箱子", "描述", PermitRarity.Universal, "RationBox", "xiangz_kanim", null);
            }
        }

    [HarmonyPatch(typeof(PermitItems), "GetOwnedCount")]
        public class PermitManager_GetOwnedCount_Patch
        {
            public static void Postfix(PermitResource permit, ref int __result)
            {
                __result++;
                Debug.Log("全蓝图补丁加载成功！！！\n 你可以尽情开始打胶了");
            }
        }

    }
}
