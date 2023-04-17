using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace minitoolbox.IndustrialBuilding.MineralDeoxidizer_Changes
{
    //氧气扩散器配置
    [HarmonyPatch(typeof(MineralDeoxidizerConfig), "CreateBuildingDef")]
    public class MineralDeoxidizer
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //氧气扩散器消耗多少瓦
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Electricity;
            //氧气扩散器是否可被淹没
            __result.Floodable = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Submerge ? false : true;
            //氧气扩散器是否过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Overheat ? false : true;
            //输出的热量dtu/s
            bool MineralDeoxidizer_heat = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_SelfHeating ? false : true;
            __result.ExhaustKilowattsWhenActive = (MineralDeoxidizer_heat ? 0.5f : 0f);
            __result.SelfHeatKilowattsWhenActive = (MineralDeoxidizer_heat ? 1f : 0f);//氧气扩散器自身热量增长dtu/s
        }
    }

    [HarmonyPatch(typeof(MineralDeoxidizerConfig), "ConfigureBuildingTemplate")]
    public class MineralDeoxidizer1
    {
        private static void Postfix(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<ElementConverter>().outputElements = new ElementConverter.OutputElement[]
            {
                new ElementConverter.OutputElement(SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_OxygenVolume, SimHashes.Oxygen, 303.15f, false, false, 0, 1, 1f, byte.MaxValue, 0, true)
            };
            Prioritizable.AddRef(go);
        }
    }
}
