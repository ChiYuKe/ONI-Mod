using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.冰箱
{
    [HarmonyPatch(typeof(RefrigeratorConfig), "CreateBuildingDef")]
    public class Refrigerator_Attributes_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            //冰箱活动时的能耗
            __result.EnergyConsumptionWhenActive = 冰箱.耗电;
            //冰箱是否会被淹没
            __result.Floodable = 冰箱.淹没;
            //冰箱是否会过热
            __result.Overheatable = 冰箱.过热;
            //__result.RequiresPowerInput = true;//冰箱是否消耗电
            //__result.SelfHeatKilowattsWhenActive = 0.125f;//冰箱自热
            Debug.LogFormat("MinBox::已调整冰箱活动时的能耗为：{0} w,冰箱是否会被淹没：{1},冰箱是否会过热：{2},冰箱容量为：{3} kg", 冰箱.耗电, 冰箱.淹没, 冰箱.过热, 冰箱.容量);
        }
       
    }
}
