using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.运输配置项.运输轨道
{
    //运输轨道
    [HarmonyPatch(typeof(SolidConduitDispenser), "ConduitUpdate")]
    public class Transport_Track_Config
    {
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> list = new List<CodeInstruction>(instructions);
            for (int i = 0; i < list.Count; i++)
            {
                bool flag = list[i].opcode == OpCodes.Ldc_R4 && (float)list[i].operand == 20f;
                if (flag)
                {
                    list[i].operand = SingletonOptions<ConfigurationItem>.Instance.Transport_Track_Capacity;
                    Debug.LogFormat("MinBox::已调整轨道运输容量为{0}kg", list[i].operand);
                }
            }
            return list.AsEnumerable<CodeInstruction>();
        }
    }
}
