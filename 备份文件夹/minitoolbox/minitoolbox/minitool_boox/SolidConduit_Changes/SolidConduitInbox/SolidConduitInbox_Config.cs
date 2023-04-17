using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.minitool_boox.SolidConduit_Changes.SolidConduitInbox
{
    //运输装载器
    [HarmonyPatch(typeof(SolidConduitInboxConfig), "CreateBuildingDef")]
    public class SolidConduitInbox_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            //运输装载器消耗多少瓦
            __result.EnergyConsumptionWhenActive = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Electricity;
            //运输装载器是否过热
            __result.Overheatable = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Overheat ? false : true;
            //自热
            bool SolidConduitInbox = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_SelfHeating ? false : true;
            __result.SelfHeatKilowattsWhenActive = (SolidConduitInbox ? 2f : 0f);//运输装载器自身热量增长dtu/s
        }
    }
}
