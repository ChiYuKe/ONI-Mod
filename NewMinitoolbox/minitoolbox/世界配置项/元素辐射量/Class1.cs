using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.世界配置项.元素辐射量
{
    [HarmonyPatch(typeof(ElementLoader), "FinaliseElementsTable")]
    public class Class1
    {
        public static void Postfix()
        {
          //  Element element4 = ElementLoader.FindElementByHash(SimHashes.Sand);
           // element4.radiationAbsorptionFactor = 940000000000f;
            // element4.materialCategory = "Metal";
           // Element element5 = ElementLoader.FindElementByHash(SimHashes.IgneousRock);
           // element5.radiationPer1000Mass = 940000000000f;
        }
    }
}
