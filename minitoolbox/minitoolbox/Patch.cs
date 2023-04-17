using System;
using System.Globalization;
using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using PeterHan.PLib.Options;

namespace minitoolbox
{
    public class Patch : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            PUtil.InitLibrary(true);
            new PLocalization().Register(null);

            CultureInfo cultureInfo = CultureInfo.CurrentUICulture;
            if (cultureInfo.Name.StartsWith("zh", StringComparison.OrdinalIgnoreCase))
            {
                new POptions().RegisterOptions(this, typeof(ConfigurationItem2));
            }
            else
            {
                new POptions().RegisterOptions(this, typeof(ConfigurationItem));
            }
        }
    }
}
