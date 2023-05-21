using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.气体过滤器
{
    //气体过滤器
    [HarmonyPatch(typeof(GasFilterConfig), "CreateBuildingDef")]
    public class GasFilter
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //气体过滤器消耗多少瓦
            __result.EnergyConsumptionWhenActive = 气体过滤器.功率;
            //气体过滤器是否过热
            __result.Overheatable = 气体过滤器.过热;
        }
    }
}
