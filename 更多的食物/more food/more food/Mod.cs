using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_food
{
    public class More_foodMod : UserMod2
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
