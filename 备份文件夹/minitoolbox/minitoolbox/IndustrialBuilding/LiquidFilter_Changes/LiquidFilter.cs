using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.IndustrialBuilding.LiquidFilter_Changes
{
    //液体过滤器
    [HarmonyPatch(typeof(LiquidFilterConfig), "CreateBuildingDef")]
    public class LiquidFilter
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //液体过滤器消耗多少瓦
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_Electricity;
            //液体过滤器是否过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_Overheat ? false : true;
            //输出的热量dtu/s
            bool LiquidFilter_heat = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_SelfHeating ? false : true;
            __result.SelfHeatKilowattsWhenActive = (LiquidFilter_heat ? 4f : 0f);//液体过滤器自身热量增长dtu/s
        }
    }
}
