using HarmonyLib;
using minitoolbox.电力配置项.发电机.人力发电机;
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
            __result.GeneratorWattageRating = 人力发电机.发电;
            __result.SelfHeatKilowattsWhenActive = 0f;

        }
    }
}
