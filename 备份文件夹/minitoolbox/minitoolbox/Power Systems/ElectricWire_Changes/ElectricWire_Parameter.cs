using HarmonyLib;
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
                    __result = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_Thinline * 1000f;
                    break;
                    //导线
                case Wire.WattageRating.Max2000:
                    __result = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_wire * 1000f;
                    break;
                    //高负荷电线
                case Wire.WattageRating.Max20000:
                    __result = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_Thickline * 1000f;
                    break;
                    //高负荷导线
                case Wire.WattageRating.Max50000:
                    __result = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_HighVoltageline * 1000f;
                    break;
                default:
                    __result = 0f;
                    break;
            }
        }
    }
}
