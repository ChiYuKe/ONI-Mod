using HarmonyLib;
using minitoolbox.电力配置项.变压器;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.Power_Systems.PowerTransformer_Changes
{
    //变压器
    [HarmonyPatch(typeof(PowerTransformerConfig), "CreateBuildingDef")]
    public class PowerTransformer
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //自热
            bool Generator_Heat = 变压器.自热;
            __result.ExhaustKilowattsWhenActive = (Generator_Heat ? 0.25f : 0f);
            __result.SelfHeatKilowattsWhenActive = (Generator_Heat ? 1f : 0f);
            __result.ExhaustKilowattsWhenActive = 0f;
            __result.SelfHeatKilowattsWhenActive = (Generator_Heat ? 1f : 0f);
            Debug.LogFormat("已调整大变压器自热为：{0}", 变压器.自热);


        }
    }
    [HarmonyPatch(typeof(PowerTransformerSmallConfig), "CreateBuildingDef")]
    public class PowerTransformer2
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //自热
            bool Generator_Heat = 变压器.自热;
            __result.ExhaustKilowattsWhenActive = (Generator_Heat ? 0.25f : 0f);
            __result.SelfHeatKilowattsWhenActive = (Generator_Heat ? 1f : 0f);
            __result.ExhaustKilowattsWhenActive = 0f;
            __result.SelfHeatKilowattsWhenActive = (Generator_Heat ? 1f : 0f);
            Debug.LogFormat("已调整小变压器自热为：{0}", 变压器.自热);


        }
    }
}
