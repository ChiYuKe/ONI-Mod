using System;
using HarmonyLib;

namespace minitoolbox.电力配置项.发电机.太阳能发电板
{
	[HarmonyPatch(typeof(SolarPanelConfig), "CreateBuildingDef")]
	public class SolarPanelRotations
	{
		private static void Postfix(SolarPanelConfig __instance, ref BuildingDef __result)
		{
			__result.PermittedRotations = PermittedRotations.R360;
			__result.GeneratorWattageRating = 太阳能发电板.发电容量;
			__result.GeneratorBaseCapacity = 太阳能发电板.发电容量;
		}
	}
}
