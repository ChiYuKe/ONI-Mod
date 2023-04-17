using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.装载器.运输装载器
{
    //运输装载器
    [HarmonyPatch(typeof(SolidConduitInboxConfig), "CreateBuildingDef")]
    public class SolidConduitInbox_Config
    {
        private static void Postfix(ref BuildingDef __result)
        {
            bool SolidConduitInbox = 运输装载器.自热;
            //运输装载器消耗多少瓦
            __result.EnergyConsumptionWhenActive = 运输装载器.功率;
            //运输装载器是否过热
            __result.Overheatable = 运输装载器.过热;
            //自热
            __result.SelfHeatKilowattsWhenActive = (SolidConduitInbox ? 2f : 0f);//运输装载器自身热量增长dtu/s
        }
    }
}
