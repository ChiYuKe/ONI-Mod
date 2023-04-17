using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penKo.二氧化碳泉
{
    [HarmonyPatch(typeof(GeyserGenericConfig), "GenerateConfigs")]
    internal class 二氧化碳泉Config
    {
        private static void Prefix()
        {
            int num = 二氧化碳泉.产物;

            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams("geyser_liquid_co2_kanim", 4, 2, new GeyserConfigurator.GeyserType("liquid_co2", Spout_Tag.testTag[num], GeyserConfigurator.GeyserShape.Liquid, 二氧化碳泉.温度, 二氧化碳泉.最低平均产率, 二氧化碳泉.最高平均产率, 二氧化碳泉.最大压力, 二氧化碳泉.最低喷发周期, 1140f, 二氧化碳泉.喷发期占比, 二氧化碳泉.喷发期占比MAX, 二氧化碳泉.最小活跃期, 135000f, 二氧化碳泉.活跃期占比, 二氧化碳泉.活跃期占比MAX, 218f, ""), true));
        }
    }
}
