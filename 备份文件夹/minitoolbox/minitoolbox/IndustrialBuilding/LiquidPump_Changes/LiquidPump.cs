using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.IndustrialBuilding.LiquidPump_Changes
{
    //液泵
    [HarmonyPatch(typeof(LiquidPumpConfig), "CreateBuildingDef")]
    public class LiquidPump
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //液泵消耗多少瓦
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_Electricity;
            //液泵是否过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_Overheat ? false : true;
            //输出的热量dtu/s
            bool LiquidPump_heat = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_SelfHeating ? false : true;
            __result.SelfHeatKilowattsWhenActive = (LiquidPump_heat ? 2f : 0f);//液泵自身热量增长dtu/s
        }
    }
}
