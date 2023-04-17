using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using minitoolbox;
using PeterHan.PLib.Options;

namespace KorribanDynamics.DynamicBuildings.Power_Changes.Generators.Solar_Panel
{
	[HarmonyPatch(typeof(SolarPanel), "EnergySim200ms")]
	public static class SolarPanel__
	{
		public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{
			
			
			List<CodeInstruction> list = new List<CodeInstruction>(instructions);
			for (int i = 0; i < list.Count; i++)
			{
				bool flag = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == 380f;
				if (flag)
				{
					list[i].operand = SingletonOptions<ConfigurationItem>.Instance.Maximum_solar_power_generation; 
				}
				bool flag2 = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == 0.00053f;
				if (flag2)
				{
					list[i].operand = SingletonOptions<ConfigurationItem>.Instance.Power_per_lux_of_solar_energy;
				}
			}
			return list.AsEnumerable<CodeInstruction>();
		}
	}
}
