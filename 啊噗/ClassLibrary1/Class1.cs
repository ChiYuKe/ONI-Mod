using System;
using Database;
using HarmonyLib;
using STRINGS;
using System.Collections.Generic;
using System.Resources;

namespace ClassLibrary1
{
    // Token: 0x02000002 RID: 2
    //HarmonyPatch(typeof(Assets), "SubstanceListHookup")]
    [HarmonyPatch(typeof(BuildingFacades), MethodType.Constructor, new Type[]
        {
            typeof(ResourceSet)
        })]
    public class Class1
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Postfix(BuildingFacades __instance)
		{
            //不进行添加，直接进行替换
            //BuildingFacades.Infos_All[10] = new BuildingFacades.Info("LuxuryBed_boat", BUILDINGS.PREFABS.LUXURYBED.FACADES.PUFT_BED.NAME, BUILDINGS.PREFABS.LUXURYBED.FACADES.PUFT_BED.DESC, PermitRarity.Loyalty, LuxuryBedConfig.ID, "a_pu_kanim");
            //将建筑蓝图添加到建筑蓝图当中去
            __instance.Add("LuxuryBed_boat", BUILDINGS.PREFABS.LUXURYBED.FACADES.PUFT_BED.NAME, BUILDINGS.PREFABS.LUXURYBED.FACADES.PUFT_BED.DESC, PermitRarity.Loyalty, "LuxuryBed", "a_pu_kanim", null);
        }
	}
}
