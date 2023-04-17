using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.Power_Systems.Dynamo_Changes.ManualGenerator_Changes
{
    //人力发电机
    [HarmonyPatch(typeof(ManualGeneratorConfig), "CreateBuildingDef")]
    public class ManualGenerator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //发电量
            __result.GeneratorWattageRating = SingletonOptions<ConfigurationItem>.Instance.ManualGeneratorr_GenerateElectricity;
            __result.SelfHeatKilowattsWhenActive = 0f;

        }
    }
}
