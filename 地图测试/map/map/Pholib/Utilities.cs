using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HarmonyLib;
using STRINGS;

namespace Pholib
{
	public class Utilities
	{
		public static bool IsSurfaceDiscovered()
		{
			return Game.Instance.savedInfo.discoveredSurface;
		}

		public static bool IsOilFieldDiscovered()
		{
			return Game.Instance.savedInfo.discoveredOilField;
		}

		public static bool IsTagDiscovered(string tag)
		{
			return DiscoveredResources.Instance.IsDiscovered(tag);
		}

		public static bool IsSimHashesDiscovered(SimHashes hash)
		{
			return DiscoveredResources.Instance.IsDiscovered(ElementLoader.FindElementByHash(hash).tag);
		}

		public static bool CycleCondition(int cycle)
		{
			return GameClock.Instance.GetCycle() >= cycle;
		}

		public static bool CycleInRange(int minimum, int maximum)
		{
			return GameClock.Instance.GetCycle() >= minimum && GameClock.Instance.GetCycle() <= maximum;
		}

		public static bool IsOnCluster(string clusterName)
		{
			if (CustomGameSettings.Instance == null)
			{
				return false;
			}
			Dictionary<string, string> value = Traverse.Create(CustomGameSettings.Instance).Field<Dictionary<string, string>>("CurrentQualityLevelsBySetting").Value;
			return value != null && value["ClusterLayout"] != null && value["ClusterLayout"].Replace("clusters/", "") == clusterName;
		}

		public static void LoadTranslations(Type locStringRoot, string modPath, string translationsDir = "translations")
		{
			Localization.RegisterForTranslation(locStringRoot);
			Localization.Locale locale = Localization.GetLocale();
			if (locale == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(modPath))
			{
				Debug.LogError("mod路径为空");
				return;
			}
			string text = Path.Combine(Path.Combine(modPath, translationsDir ?? ""), locale.Code + ".po");
			Debug.Log(string.Format("加载翻译文件 {0} ({1}) 语言: '{2}'", locale.Lang, locale.Code, text));
			if (!File.Exists(text))
			{
				Debug.LogWarning("找不到翻译文件: '" + text + "'");
				return;
			}
			try
			{
				Localization.OverloadStrings(Localization.LoadStringsFile(text, false));
			}
			catch (Exception obj)
			{
				Debug.LogError("加载翻译文件时出现意外错误: '" + text + "'");
				Debug.LogError(obj);
			}
		}

		public static void AddCarePackage(ref Immigration immigration, string objectId, float amount, Func<bool> requirement = null)
		{
			Traverse traverse = Traverse.Create(immigration).Field("carePackages");
			List<CarePackageInfo> list = traverse.GetValue<CarePackageInfo[]>().ToList<CarePackageInfo>();
			list.Add(new CarePackageInfo(objectId, amount, requirement));
			traverse.SetValue(list.ToArray());
		}

		public static void AddWorldYaml(Type className)
		{
			if (!Utilities.alreadyLoaded.Contains(className))
			{
				ModUtil.RegisterForTranslation(className);
				Utilities.alreadyLoaded.Add(className);
			}
		}

		public static void AddBuilding(string category, string id, string name, string desc, string effect)
		{
			string str = id.ToUpperInvariant();
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + str + ".NAME",
				UI.FormatAsLink(name, id)
			});
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + str + ".DESC",
				desc
			});
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + str + ".EFFECT",
				effect
			});
			ModUtil.AddBuildingToPlanScreen(category, id);
		}

		public static void AddBuildingTech(string techId, string buildingId)
		{
			Db.Get().Techs.Get(techId).unlockedItemIDs.Add(buildingId);
		}

		public static ComplexRecipe AddComplexRecipe(ComplexRecipe.RecipeElement[] input, ComplexRecipe.RecipeElement[] output, string fabricatorId, float productionTime, LocString recipeDescription, ComplexRecipe.RecipeNameDisplay nameDisplayType, int sortOrder, string requiredTech = null)
		{
			return new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(fabricatorId, input, output), input, output)
			{
				time = productionTime,
				description = recipeDescription,
				nameDisplay = nameDisplayType,
				fabricators = new List<Tag>
				{
					fabricatorId
				},
				sortOrder = sortOrder,
				requiredTech = requiredTech
			};
		}

		private static readonly List<Type> alreadyLoaded = new List<Type>();
	}
}
