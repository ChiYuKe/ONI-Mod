using HarmonyLib;
using minitoolbox.电力配置项.电源线;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.Power_Systems.ElectricWire_Changes
{
    //电线
    [HarmonyPatch(typeof(Wire), "GetMaxWattageAsFloat")]
    public class ElectricWire_Parameter
    {
        public static void Postfix(Wire __instance, ref float __result, Wire.WattageRating rating)
        {
            switch (rating)
            {
                case Wire.WattageRating.Max500:
                    __result = 500f;
                    break;
                    //电线
                case Wire.WattageRating.Max1000:
                    __result = 电源线.电线;
                    Debug.LogFormat("已调整最大电线负载为{0}", 电源线.电线);
                    break;
                    //导线
                case Wire.WattageRating.Max2000:
                    __result = 电源线.导线;
                    break;
                    //高负荷电线
                case Wire.WattageRating.Max20000:
                    __result = 电源线.高负荷电线;
                    break;
                    //高负荷导线
                case Wire.WattageRating.Max50000:
                    __result = 电源线.高负荷导线;
                    break;
                default:
                    __result = 0f;
                    break;
            }
        }
    }
}
