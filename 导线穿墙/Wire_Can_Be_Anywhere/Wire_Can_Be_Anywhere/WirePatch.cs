using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Can_Be_Anywhere
{
    internal class WirePatch
    {
        public class Patch : UserMod2
        {
            // Token: 0x060000DB RID: 219 RVA: 0x00002CDA File Offset: 0x00000EDA
            public override void OnLoad(Harmony harmony)
            {
                PUtil.InitLibrary(true);
                new POptions().RegisterOptions(this, typeof(Config));
                base.OnLoad(harmony);
            }
        }
    }
}
