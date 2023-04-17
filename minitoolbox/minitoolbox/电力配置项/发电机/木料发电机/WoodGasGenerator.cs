using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.电力配置项.发电机.木料发电机
{
    //木料发电机
    [HarmonyPatch(typeof(WoodGasGeneratorConfig), "CreateBuildingDef")]
    public class WoodGasGenerator
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //自热
            bool WoodGasGenerator_Heat = 木料发电机.自热;
            //发电量
            __result.GeneratorWattageRating = 木料发电机.发电;
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
            energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(WoodLogConfig.TAG, 1.2f, 720f, SimHashes.CarbonDioxide, 木料发电机.碳排放, false, new CellOffset(0, 1), 298.15f);

        }
    }
}
