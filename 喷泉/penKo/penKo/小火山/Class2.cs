using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static STRINGS.BUILDINGS.PREFABS.CANVAS.FACADES;
using UnityEngine;

namespace penKo.小火山
{
    [HarmonyPatch(typeof(GeyserGenericConfig), "GenerateConfigs")]
    internal class 小火山Config
    {
        private static void Prefix()
        {

            int num = 小火山.产物;
           
            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams("geyser_molten_volcano_small_kanim", 3, 3, new GeyserConfigurator.GeyserType("small_volcano", Spout_Tag.testTag[num], GeyserConfigurator.GeyserShape.Molten, 小火山.温度, 小火山.最低平均产率, 小火山.最高平均产率, 小火山.最大压力, 小火山.最低喷发周期, 12000f, 小火山.喷发期占比, 小火山.喷发期占比MAX, 小火山.最小活跃期, 135000f, 小火山.活跃期占比, 小火山.活跃期占比MAX, 372.15f, ""), true));
        }
    }
}
