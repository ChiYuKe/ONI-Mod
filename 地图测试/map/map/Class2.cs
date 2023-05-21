using System;
using System.Collections.Generic;
using HarmonyLib;
using ProcGen;
namespace map
{
    public class WorldGenPatches
    {
        public class ExtremelyCold2_patch
        {
            private static void AddHashToTable(Temperature.Range hash, string id)
            {
                WorldGenPatches.ExtremelyCold2_patch.TemperatureTable.Add(hash, id);
                WorldGenPatches.ExtremelyCold2_patch.TemperatureReverseTable.Add(id, hash);
            }

            public static void OnLoad()
            {
                Temperature.Range range = (Temperature.Range)Hash.SDBMLower("ExtremelyCold2");
                if (!WorldGenPatches.ExtremelyCold2_patch.TemperatureTable.ContainsKey(range))
                {
                    WorldGenPatches.ExtremelyCold2_patch.AddHashToTable(range, "ExtremelyCold2");
                }
            }

            public static Dictionary<Temperature.Range, string> TemperatureTable = new Dictionary<Temperature.Range, string>();

            public static Dictionary<string, object> TemperatureReverseTable = new Dictionary<string, object>();

            [HarmonyPatch(typeof(Enum), "ToString", new Type[]
            {

            })]
            public static class Temperatures_ToString_Patch
            {
                public static bool Prefix(ref Enum __instance, ref string __result)
                {
                    return !(__instance is Temperature.Range) || !WorldGenPatches.ExtremelyCold2_patch.TemperatureTable.TryGetValue((Temperature.Range)__instance, out __result);
                }
            }

            [HarmonyPatch(typeof(Enum), "Parse", new Type[]
            {
                typeof(Type),
                typeof(string),
                typeof(bool)
            })]
            public static class Temperatures_Parse_Patch
            {
                public static bool Prefix(Type enumType, string value, ref object __result)
                {
                    return !enumType.Equals(typeof(Temperature.Range)) || !WorldGenPatches.ExtremelyCold2_patch.TemperatureReverseTable.TryGetValue(value, out __result);
                }
            }
        }
    }
}
