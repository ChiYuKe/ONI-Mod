using System;
using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;

namespace Dark_Moon_GalaxyTree
{
    public class Dark_Moon_GalaxyTreeMod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            CaiLib.Logger.Logger.LogInit(base.mod);
            PUtil.InitLibrary(true);
            new PLocalization().Register(null);
        }
    }
}
