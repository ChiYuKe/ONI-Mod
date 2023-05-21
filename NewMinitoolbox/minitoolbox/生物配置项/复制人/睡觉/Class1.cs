using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.生物配置项.复制人.睡觉
{
    [HarmonyPatch(typeof(MinionConfig), "AddMinionTraits")]
    public static class NoWantSleep
    {
      
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> list = new List<CodeInstruction>(instructions);
            for (int i = 0; i < list.Count; i++)
            {
                bool flag = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == -0.11666667f;
                if (flag)
                {
                    bool NoWantSleep = SingletonOptions<ConfigurationItem>.Instance.NoWantSleepPatch;
                    if (NoWantSleep)
                    {
                        list[i].operand = 0f;
                    }
                    else
                    {
                        list[i].operand = -0.11666667f;
                    }
                }
            }
            return list.AsEnumerable<CodeInstruction>();
        }
    }
}
