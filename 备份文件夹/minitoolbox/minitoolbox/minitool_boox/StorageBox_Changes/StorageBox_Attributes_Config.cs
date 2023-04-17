using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.minitool_boox.StorageBox_Changes
{
    [HarmonyPatch(typeof(StorageLockerConfig), "CreateBuildingDef")]
    public class StorageBox_Attributes_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            //是否会过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.StorageBox_Overheat ? false: true;
        }
    }
}
