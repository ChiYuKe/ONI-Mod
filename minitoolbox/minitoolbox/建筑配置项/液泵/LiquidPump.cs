using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.液泵
{
    //液泵
    [HarmonyPatch(typeof(LiquidPumpConfig), "CreateBuildingDef")]
    public class LiquidPump
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //液泵消耗多少瓦
            __result.EnergyConsumptionWhenActive = 液泵.功率;
            //液泵是否过热
            __result.Overheatable = 液泵.过热;
            //输出的热量dtu/s
            bool LiquidPump_heat = 液泵.发热;
            __result.SelfHeatKilowattsWhenActive = (LiquidPump_heat ? 2f : 0f);//液泵自身热量增长dtu/s
        }
    }
}
