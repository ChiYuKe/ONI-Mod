using System;
using HarmonyLib;

namespace KorribanDynamics.DynamicBuildings.Power_Changes.Generators.Solar_Panel
{
	[HarmonyPatch(typeof(SolarPanelConfig), "CreateBuildingDef")]
	public class SolarPanelRotations
	{
		private static void Postfix(SolarPanelConfig __instance, ref BuildingDef __result)
		{
			__result.PermittedRotations = PermittedRotations.R360;
			__result.GeneratorWattageRating = 3780f;
			__result.GeneratorBaseCapacity = 3780f;
		}
	}
}
