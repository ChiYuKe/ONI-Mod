using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.世界配置项.擦水
{
    [HarmonyPatch(typeof(MopTool), "OnPrefabInit")]
    public class Mop_Config
    {
        //擦水
        public static void Postfix()
        {
            MopTool.maxMopAmt = (SingletonOptions<ConfigurationItem>.Instance.Mop_Max ? 90000000f:150f);
        }
    }
}