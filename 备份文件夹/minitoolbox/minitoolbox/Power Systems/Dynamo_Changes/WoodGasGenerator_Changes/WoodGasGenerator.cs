using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.Power_Systems.Dynamo_Changes.WoodGasGenerator_Changes
{
    //木料发电机
    [HarmonyPatch(typeof(WoodGasGeneratorConfig), "CreateBuildingDef")]
    public class WoodGasGenerator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //发电量
            __result.GeneratorWattageRating = SingletonOptions<ConfigurationItem>.Instance.WoodGasGenerator_GenerateElectricity;
            //自热
            bool WoodGasGenerator_Heat = SingletonOptions<ConfigurationItem>.Instance.WoodGasGenerator_SelfHeating ? false : true;
            __result.SelfHeatKilowattsWhenActive = (WoodGasGenerator_Heat ? 1f : 0f);
            __result.ExhaustKilowattsWhenActive = (WoodGasGenerator_Heat ? 8f : 0f);

        }
    }
    [HarmonyPatch(typeof(WoodGasGeneratorConfig), "DoPostConfigureComplete")]
    public class WoodGasGenerator2
    {
        public static void Postfix(GameObject go)
        {
            EnergyGenerator energyGenerator = go.AddOrGet<EnergyGenerator>();
            energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(WoodLogConfig.TAG, 1.2f, 720f, SimHashes.CarbonDioxide, SingletonOptions<ConfigurationItem>.Instance.WoodGasGenerator_CarbonDioxideVolume, false, new CellOffset(0, 1), 298.15f);

        }
    }
}
