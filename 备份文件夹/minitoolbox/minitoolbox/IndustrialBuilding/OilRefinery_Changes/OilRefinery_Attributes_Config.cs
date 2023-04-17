using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static ElementConverter;

namespace minitoolbox.IndustrialBuilding.OilRefinery_Changes
{
    //原油精炼器
    [HarmonyPatch(typeof(OilRefineryConfig), "CreateBuildingDef")]
    public class OilRefinery_Attributes_Config
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //原油精炼器消耗多少瓦
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Electricity;
            //原油精炼器是否可被淹没
            __result.Floodable = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Submerge ? false : true;
            //原油精炼器是否过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Overheat ? false : true;
            //输出的热量dtu/s
            bool OilRefinery_heat = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_SelfHeating ? false : true;
            __result.ExhaustKilowattsWhenActive = (OilRefinery_heat ? 2f : 0f);
            __result.SelfHeatKilowattsWhenActive = (OilRefinery_heat ? 8f : 0f);//电解器自身热量增长dtu/s
        }
    }
    [HarmonyPatch(typeof(OilRefineryConfig), "ConfigureBuildingTemplate")]
    public class OilRefinery_Attributes_Config2
    {
        public static void Postfix(GameObject go, Tag prefab_tag)
        {
            
            go.AddOrGet<ElementConverter>().outputElements = new ElementConverter.OutputElement[]
            {
                new ElementConverter.OutputElement(SingletonOptions<ConfigurationItem>.Instance.PetroleumVolume, SimHashes.Petroleum, 298.15f, false, true, 0f, 1f, 1f, byte.MaxValue, 0, true),
                new ElementConverter.OutputElement(SingletonOptions<ConfigurationItem>.Instance.MethaneVolume, SimHashes.Methane, 298.15f, false, false, 0f, 3f, 1f, byte.MaxValue, 0, true)
            };
        }
    }
    [HarmonyPatch(typeof(OilRefineryConfig), "DoPostConfigureComplete")]
    public class OilRefinery_Attributes_Config3
    {
        public static void Postfix(GameObject go)
        {
            bool OilRefinery_NF = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_automatic ? true : false;
            if(OilRefinery_NF)
            {
                OilRefinery obj = go.AddOrGet<OilRefinery>();
                UnityEngine.Object.Destroy(obj);
                go.AddOrGet<OilRefineryAttributes>();
                //小人操作
                go.AddOrGet<BuildingComplete>().isManuallyOperated = false;
            }
        }
    }
}
