using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox
{
    public class Patch : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            PUtil.InitLibrary(true);
            new POptions().RegisterOptions(this, typeof(ConfigurationItem));
            base.OnLoad(harmony);
        }
    }
}
