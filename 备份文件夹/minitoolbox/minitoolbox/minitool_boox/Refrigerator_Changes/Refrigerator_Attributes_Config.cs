using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.minitool_boox.Refrigerator_Changes
{
    [HarmonyPatch(typeof(RefrigeratorConfig), "CreateBuildingDef")]
    public class Refrigerator_Attributes_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            //冰箱活动时的能耗
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Electricity;
            //冰箱是否会被淹没
            __result.Floodable = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Submerge ? false: true;
            //冰箱是否会过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Overheat ? false: true;
            //__result.RequiresPowerInput = true;//冰箱是否消耗电
            //__result.SelfHeatKilowattsWhenActive = 0.125f;//冰箱自热
        }
    }
}
