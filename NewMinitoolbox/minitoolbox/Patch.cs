using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using PeterHan.PLib.Options;
using UnityEngine.Diagnostics;

namespace minitoolbox
{
    public class Patch : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            PUtil.InitLibrary(true);
            new POptions().RegisterOptions(this, typeof(ConfigurationItem));
        }

        [HarmonyPatch(typeof(Localization))]
        [HarmonyPatch("Initialize")]
        private class Translate
        {
            public static void Postfix()
            {
                Localize(typeof(STRINGS));
            }
        }
        public static void Localize(Type root)
        {
            ModUtil.RegisterForTranslation(root);
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = executingAssembly.GetName().Name;
            string path = Path.Combine(Path.GetDirectoryName(executingAssembly.Location), "translations");
            Localization.Locale locale = Localization.GetLocale();
            bool flag = locale != null;
            if (flag)
            {
                try
                {
                    string text = Path.Combine(path, locale.Code + ".po");
                    Debug.LogWarning(name + " lang file: " + text);
                    bool flag2 = File.Exists(text);
                    if (flag2)
                    {
                        Debug.Log(name + ": Localize file found " + text);
                        Localization.OverloadStrings(Localization.LoadStringsFile(text, false));
                    }
                }
                catch
                {
                    Debug.LogWarning(name + " Failed to load localization.");
                }
            }
            LocString.CreateLocStringKeys(root, "");
        }
    }
}
