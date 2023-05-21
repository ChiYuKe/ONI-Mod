using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace map
{
    [HarmonyPatch(typeof(BackgroundEarthConfig))]
    [HarmonyPatch("CreatePrefab")]
    internal class MapConfig
    {
        public static void Postfix(GameObject __result)
        {
            MapConfig.earthAnimController = __result.AddOrGet<KBatchedAnimController>();
        }
        public static KBatchedAnimController earthAnimController;
    }
}
