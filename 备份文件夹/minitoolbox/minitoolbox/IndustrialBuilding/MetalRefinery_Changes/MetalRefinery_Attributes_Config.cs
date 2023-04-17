using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.IndustrialBuilding.MetalRefinery_Changes
{
    //金属精炼器
    [HarmonyPatch(typeof(MetalRefineryConfig), "CreateBuildingDef")]
    public class MetalRefinery_Attributes_Config
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //耗电
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Electricity;
            //自热
            bool setJs = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_SelfHeating ? false : true;
            //淹没
            __result.Floodable = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Submerge ? false : true;
            //过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Overheat ? false : true;
            __result.SelfHeatKilowattsWhenActive = (setJs ? 16f : 0f);
        }
    }
}
