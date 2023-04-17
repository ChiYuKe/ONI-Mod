using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penKo.二氧化碳喷孔
{
    [HarmonyPatch(typeof(GeyserGenericConfig), "GenerateConfigs")]
    public class 二氧化碳喷孔Config
    {
        private static void Prefix()
        {
            int num = 二氧化碳喷孔.产物;

            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams("geyser_gas_co2_hot_kanim", 2, 4, new GeyserConfigurator.GeyserType("hot_co2", Spout_Tag.testTag[num], GeyserConfigurator.GeyserShape.Gas, 二氧化碳喷孔.温度, 二氧化碳喷孔.最低平均产率, 二氧化碳喷孔.最高平均产率, 二氧化碳喷孔.最大压力, 二氧化碳喷孔.最低喷发周期, 1140f, 二氧化碳喷孔.喷发期占比, 二氧化碳喷孔.喷发期占比MAX, 二氧化碳喷孔.最小活跃期, 135000f, 二氧化碳喷孔.活跃期占比, 二氧化碳喷孔.活跃期占比MAX, 372.15f, ""), true));
        }
    }
}
