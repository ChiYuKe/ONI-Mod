using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.世界配置项.挖掘
{
    //挖掘倍率调整
    [HarmonyPatch(typeof(WorldDamage), "OnDigComplete")]
    public class HightDiggingRatio
    {
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instr)
        {
            foreach (CodeInstruction codeInstruction in instr.ToList<CodeInstruction>())
            {
                //挖掘倍率，默认是0.5
                if (codeInstruction.opcode == OpCodes.Ldc_R4 && (double)((float)codeInstruction.operand) == 0.5)
                {
                
                    codeInstruction.operand = SingletonOptions<ConfigurationItem>.Instance.HightDiggingRatio_Magnification;
                }
                yield return codeInstruction;
            }
            List<CodeInstruction>.Enumerator i = default(List<CodeInstruction>.Enumerator);
            yield break;
        }
    }
}
