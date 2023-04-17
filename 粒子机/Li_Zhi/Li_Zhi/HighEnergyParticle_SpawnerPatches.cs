using HarmonyLib;
using PeterHan.PLib.Options;
using UnityEngine;

namespace Li_Zhi
{
    public static class HighEnergyParticle_SpawnerPatches
    {

        [HarmonyPatch(typeof(HighEnergyParticleSpawnerConfig), "ConfigureBuildingTemplate")]
        private static class Patch_HighEnergyParticle_Spawner_ConfigureBuildingTemplate
        {
            public static void Postfix(GameObject go)
            {
                go.AddOrGet<HighEnergyParticleSpawner>().radiationSampleRate = SingletonOptions<Config>.Instance.WireRefinedHighWattage_BaseDecor;
            }
        }
    }
}
