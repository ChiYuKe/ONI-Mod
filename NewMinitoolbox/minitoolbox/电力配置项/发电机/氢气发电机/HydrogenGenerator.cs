using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.发电机.氢气发电机
{
    //氢气发电机
    [HarmonyPatch(typeof(HydrogenGeneratorConfig), "CreateBuildingDef")]
    public class HydrogenGenerator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //发电量
            __result.GeneratorWattageRating = 氢气发电机.发电;
            //自热
            bool WoodGasGenerator_Heat = 氢气发电机.自热;
            __result.SelfHeatKilowattsWhenActive = (WoodGasGenerator_Heat ? 2f : 0f);
            __result.ExhaustKilowattsWhenActive = (WoodGasGenerator_Heat ? 2f : 0f);

        }
    }
}
