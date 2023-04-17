using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.世界配置项.单物品最大堆叠
{
    [HarmonyPatch(typeof(ElementSplitterComponents), "CanFirstAbsorbSecond")]
    public static class StorageStacks_
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            float num = 1000f;
            List<CodeInstruction> list = new List<CodeInstruction>(instructions);
            for (int i = 0; i < list.Count; i++)
            {
                bool flag = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == 25000f;
                if (flag)
                {
                    list[i].operand = 100 * num;
                }
            }
            return list.AsEnumerable<CodeInstruction>();
        }
    }
}
