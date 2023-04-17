using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penKo.氯气喷孔
{
    [HarmonyPatch(typeof(GeyserGenericConfig), "GenerateConfigs")]
    public class 氯气喷孔Config
    {
        private static void Prefix()
        {
            int num = 氯气喷孔.产物;

            //SimHashes.ChlorineGas
            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams("geyser_gas_chlorine_kanim", 2, 4, new GeyserConfigurator.GeyserType("chlorine_gas", Spout_Tag.testTag[num], GeyserConfigurator.GeyserShape.Gas, 氯气喷孔.温度, 氯气喷孔.最低平均产率, 氯气喷孔.最高平均产率, 氯气喷孔.最大压力, 氯气喷孔.最低喷发周期, 1140f, 氯气喷孔.喷发期占比, 氯气喷孔.喷发期占比MAX, 氯气喷孔.最小活跃期, 135000f, 氯气喷孔.活跃期占比, 氯气喷孔.活跃期占比MAX, 372.15f, ""), true));
         
        }
    }
}
