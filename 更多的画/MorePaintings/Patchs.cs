using System;
using HarmonyLib;
using KMod;
using STRINGS;
using PeterHan.PLib.Database;

namespace more_paintings
{
    public class ModLoad : UserMod2
    {
        public static string Namespace { get; private set; }
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            ModLoad.Namespace = base.GetType().Namespace;
            new PLocalization().Register(null);
        }
    }

    internal class BasicModUtils
    {
        public static void MakeSideScreenStrings(string key, string name)
        {
            Strings.Add(new string[]
            {
                key,
                name
            });
        }
    }

    internal class screen_information
    {
        [HarmonyPatch(typeof(DetailsScreen), "OnPrefabInit")]
        public static class PrefabInit_Patch
        {
            public static void Postfix()
            {
                FUI_SideScreen.AddClonedSideScreen<SignSideScreen>("标志侧屏", "MonumentSideScreen", typeof(MonumentSideScreen));
            }
        }
    }

    [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	public class Patchs
	{
		public static void Prefix()
		{
			BasicModUtils.MakeSideScreenStrings("UI", STRINGS.N.name);
			ModUtil.AddBuildingToPlanScreen("Furniture", "MorePaintings");

            Strings.Add("STRINGS.BUILDINGS.PREFABS.MOREPAINTINGS.NAME", UI.FormatAsLink("MorePaintings", "MOREPAINTINGS"));
            Strings.Add("STRINGS.BUILDINGS.PREFABS.MOREPAINTINGS.DESC", "最近来了一批新的画，让复制人起信誉了");
            Strings.Add("STRINGS.BUILDINGS.PREFABS.MOREPAINTINGS.EFFECT", "复制人看到都称赞，好！");
        }
	}
}
