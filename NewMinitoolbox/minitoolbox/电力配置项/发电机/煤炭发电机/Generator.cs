using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.电力配置项.发电机.煤炭发电机
{
    //煤炭发电机
    [HarmonyPatch(typeof(GeneratorConfig), "CreateBuildingDef")]
    public class Generator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //自热
            bool Generator_Heat = 煤炭发电机.自热;
            //发电量
            __result.GeneratorWattageRating = 煤炭发电机.发电;
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
            energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(SimHashes.Carbon.CreateTag(), 1f, 600f, SimHashes.CarbonDioxide, 煤炭发电机.碳排放, false, new CellOffset(1, 2), 298.15f);
        }
    }
}
