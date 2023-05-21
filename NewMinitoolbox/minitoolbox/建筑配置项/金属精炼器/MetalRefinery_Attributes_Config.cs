using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.金属精炼器
{
    //金属精炼器
    [HarmonyPatch(typeof(MetalRefineryConfig), "CreateBuildingDef")]
    public class MetalRefinery_Attributes_Config
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //耗电
            __result.EnergyConsumptionWhenActive = 金属精炼器.功率;
            //自热
            bool setJs = 金属精炼器.发热;
            //淹没
            __result.Floodable = 金属精炼器.淹没;
            //过热
            __result.Overheatable = 金属精炼器.过热;
            __result.SelfHeatKilowattsWhenActive = (setJs ? 16f : 0f);
        }
    }
}
