using System;
using STRINGS;

namespace CaiLib.Utils
{
	// Token: 0x0200000F RID: 15
	public static class StringUtils
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public static void AddBuildingStrings(string buildingId, string name, string description, string effect)
		{
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".NAME",
				UI.FormatAsLink(name, buildingId)
			});
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".DESC",
				description
			});
			Strings.Add(new string[]
			{
				"STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".EFFECT",
				effect
			});
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002B3C File Offset: 0x00000D3C
		public static void AddPlantStrings(string plantId, string name, string description, string domesticatedDescription)
		{
			Strings.Add(new string[]
			{
				"STRINGS.CREATURES.SPECIES." + plantId.ToUpperInvariant() + ".NAME",
				UI.FormatAsLink(name, plantId)
			});
			Strings.Add(new string[]
			{
				"STRINGS.CREATURES.SPECIES." + plantId.ToUpperInvariant() + ".DESC",
				description
			});
			Strings.Add(new string[]
			{
				"STRINGS.CREATURES.SPECIES." + plantId.ToUpperInvariant() + ".DOMESTICATEDDESC",
				domesticatedDescription
			});
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public static void AddPlantSeedStrings(string plantId, string name, string description)
		{
			Strings.Add(new string[]
			{
				"STRINGS.CREATURES.SPECIES.SEEDS." + plantId.ToUpperInvariant() + ".NAME",
				UI.FormatAsLink(name, plantId)
			});
			Strings.Add(new string[]
			{
				"STRINGS.CREATURES.SPECIES.SEEDS." + plantId.ToUpperInvariant() + ".DESC",
				description
			});
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C2C File Offset: 0x00000E2C
		public static void AddFoodStrings(string foodId, string name, string description, string recipeDescription = null)
		{
			Strings.Add(new string[]
			{
				"STRINGS.ITEMS.FOOD." + foodId.ToUpperInvariant() + ".NAME",
				UI.FormatAsLink(name, foodId)
			});
			Strings.Add(new string[]
			{
				"STRINGS.ITEMS.FOOD." + foodId.ToUpperInvariant() + ".DESC",
				description
			});
			bool flag = recipeDescription != null;
			if (flag)
			{
				Strings.Add(new string[]
				{
					"STRINGS.ITEMS.FOOD." + foodId.ToUpperInvariant() + ".RECIPEDESC",
					recipeDescription
				});
			}
		}
	}
}
