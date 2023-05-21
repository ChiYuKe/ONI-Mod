using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.自动清扫器
{
    //自动清扫器
    [HarmonyPatch(typeof(SolidTransferArmConfig), "CreateBuildingDef")]
    public class SolidTransferArm
    {
        public static void Postfix(ref BuildingDef __result)
        {
            //自动清扫器消耗多少瓦
            __result.EnergyConsumptionWhenActive = 自动清扫器.功率;
            //自动清扫器是否过热
            __result.Overheatable = 自动清扫器.过热;
            //输出的热量dtu/s
            bool SolidTransferArm_heat = 自动清扫器.发热;
            __result.SelfHeatKilowattsWhenActive = (SolidTransferArm_heat ? 2f : 0f);//自动清扫器自身热量增长dtu/s
        }
    }
}
