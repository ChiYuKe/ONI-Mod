using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.Power_Systems.Dynamo_Changes.Generator_Changes
{
    //煤炭发电机
    [HarmonyPatch(typeof(GeneratorConfig), "CreateBuildingDef")]
    public class Generator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //发电量
            __result.GeneratorWattageRating = SingletonOptions<ConfigurationItem>.Instance.Generator_GenerateElectricity;
            //自热
            bool Generator_Heat = SingletonOptions<ConfigurationItem>.Instance.Generator_SelfHeating ? false : true;
            __result.ExhaustKilowattsWhenActive = (Generator_Heat ? 8f : 0f);
            __result.SelfHeatKilowattsWhenActive = (Generator_Heat ? 1f : 0f);
            

        }
    }
    [HarmonyPatch(typeof(GeneratorConfig), "ConfigureBuildingTemplate")]
    public class Generator2
    {
        public static void Postfix(GameObject go)
        {
            EnergyGenerator energyGenerator = go.AddOrGet<EnergyGenerator>();
            energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(SimHashes.Carbon.CreateTag(), 1f, 600f, SimHashes.CarbonDioxide, SingletonOptions<ConfigurationItem>.Instance.Generator_CarbonDioxideVolume, false, new CellOffset(1, 2), 298.15f);
        }
    }
}
