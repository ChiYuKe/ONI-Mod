using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.储存箱
{
    [HarmonyPatch(typeof(StorageLockerConfig), "CreateBuildingDef")]
    public class StorageBox_Attributes_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            //是否会过热
            //__result.Overheatable = 储存箱.过热;
        }
    }
}
