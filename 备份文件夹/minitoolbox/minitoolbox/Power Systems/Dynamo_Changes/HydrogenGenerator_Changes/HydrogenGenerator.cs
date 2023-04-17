using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.Power_Systems.Dynamo_Changes.HydrogenGenerator_Changes
{
    //氢气发电机
    [HarmonyPatch(typeof(HydrogenGeneratorConfig), "CreateBuildingDef")]
    public class HydrogenGenerator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //发电量
            __result.GeneratorWattageRating = SingletonOptions<ConfigurationItem>.Instance.HydrogenGenerator_GenerateElectricity;
            //自热
            bool WoodGasGenerator_Heat = SingletonOptions<ConfigurationItem>.Instance.HydrogenGenerator_SelfHeating ? false : true;
            __result.SelfHeatKilowattsWhenActive = (WoodGasGenerator_Heat ? 2f : 0f);
            __result.ExhaustKilowattsWhenActive = (WoodGasGenerator_Heat ? 2f : 0f);

        }
    }
}
