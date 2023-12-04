using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using YamlDotNet.Core.Tokens;
using static STRINGS.BUILDINGS.PREFABS;

namespace minitoolbox.建筑配置项.电解器
{
    [HarmonyPatch(typeof(ElectrolyzerConfig), "CreateBuildingDef")]
    public class Electrolyzer_Attributes_Config
    {
        public static void Postfix(ref BuildingDef __result)
        {
            __result.EnergyConsumptionWhenActive = 电解器.功率;
            __result.Floodable = 电解器.淹没;
            __result.Overheatable = 电解器.过热;
            bool Electrolyzer_heat = 电解器.发热;
            __result.ExhaustKilowattsWhenActive = (Electrolyzer_heat ? 0.25f : 0f);
            __result.SelfHeatKilowattsWhenActive = (Electrolyzer_heat ? 1f : 0f);//电解器自身热量增长dtu/s
        }
    }
    [HarmonyPatch(typeof(ElectrolyzerConfig), "ConfigureBuildingTemplate")]
    public class Electrolyzer_Attributes_Config2
    {
        private static void Postfix(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<ElementConverter>().outputElements = new ElementConverter.OutputElement[]
            {
                new ElementConverter.OutputElement(电解器.氧气排放量, SimHashes.Oxygen, 298.15f, SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_SelfHeating, false, 0f, 1f, 1f, 0, 0),
                new ElementConverter.OutputElement(电解器.氢气排放量, SimHashes.Hydrogen, 298.15f, SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_SelfHeating, false, 0f, 1f, 1f, 0, 0)
            };
            Prioritizable.AddRef(go);
        }
    }

}
