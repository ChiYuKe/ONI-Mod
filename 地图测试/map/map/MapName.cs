using HarmonyLib;
using Pholib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    [HarmonyPatch(typeof(Db))]
    [HarmonyPatch("Initialize")]
    public class WorldAdds
    {
        // Token: 0x0600000C RID: 12 RVA: 0x00002320 File Offset: 0x00000520
        public static void Postfix()
        {
            Utilities.AddWorldYaml(typeof(WorldAdds));
            Strings.Add(new string[]
            {
                "STRINGS.SUBWORLDS.EARTH.NAME",
                WorldAdds.E_NAME
            });
            Strings.Add(new string[]
            {
                "STRINGS.SUBWORLDS.EARTH.DESC",
                WorldAdds.E_DESC
            });
        }

        public static LocString E_NAME = "暗月星河";
        public static LocString E_DESC = " 额......这颗星球是星河打胶打出来的\n\n";
        public static string EarthId = WorldAdds.E_NAME;

    }
}
