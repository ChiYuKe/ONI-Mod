using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using minitoolbox;
using PeterHan.PLib.Options;

namespace minitoolbox.电力配置项.发电机.太阳能发电板
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
					list[i].operand = 太阳能发电板.发电容量;

                }
				bool flag2 = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == 0.00053f;
				if (flag2)
				{
					list[i].operand = 太阳能发电板.太阳能;

                }
			}
			return list.AsEnumerable<CodeInstruction>();
		}
	}
}
