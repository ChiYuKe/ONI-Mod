using HarmonyLib;
using KMod;
using Pholib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    public class AllBiomesWorld : UserMod2
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            Logs.DebugLog = true;
            WorldGenPatches.ExtremelyCold2_patch.OnLoad();
        }
    }
}
