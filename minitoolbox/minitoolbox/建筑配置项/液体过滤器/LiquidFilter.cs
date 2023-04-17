using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.液体过滤器
{
    //液体过滤器
    [HarmonyPatch(typeof(LiquidFilterConfig), "CreateBuildingDef")]
    public class LiquidFilter
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //液体过滤器消耗多少瓦
            __result.EnergyConsumptionWhenActive = 液体过滤器.功率;
            //液体过滤器是否过热
            __result.Overheatable = 液体过滤器.过热;
            //输出的热量dtu/s
            bool LiquidFilter_heat = 液体过滤器.发热;
            __result.SelfHeatKilowattsWhenActive = (LiquidFilter_heat ? 4f : 0f);//液体过滤器自身热量增长dtu/s
        }
    }
}
