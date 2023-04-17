using System;
using System.Collections.Generic;
using UnityEngine;

namespace CaiLib.Utils
{
	// Token: 0x0200000B RID: 11
	public class CritterDietUtils
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000280C File Offset: 0x00000A0C
		public static void AddToDiet(List<Diet.Info> dietInfos, HashSet<Tag> consumedTags, Tag poopTag, float dailyCalories, float dailyKilograms, float conversionRate = 1f, string diseaseId = "", float diseasePerKg = 0f)
		{
			dietInfos.Add(string.IsNullOrEmpty(diseaseId) ? new Diet.Info(consumedTags, poopTag, dailyCalories / dailyKilograms, conversionRate, null, 0f, false, false) : new Diet.Info(consumedTags, poopTag, dailyCalories / dailyKilograms, conversionRate, diseaseId, diseasePerKg, false, false));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002854 File Offset: 0x00000A54
		public static void AddToDiet(List<Diet.Info> dietInfos, Tag consumedTag, Tag poopTag, float dailyCalories, float dailyKilograms, float conversionRate = 1f, string diseaseId = "", float diseasePerKg = 0f)
		{
			CritterDietUtils.AddToDiet(dietInfos, new HashSet<Tag>(new Tag[]
			{
				consumedTag
			}), poopTag, dailyCalories, dailyKilograms, conversionRate, diseaseId, diseasePerKg);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000287C File Offset: 0x00000A7C
		public static void AddToDiet(List<Diet.Info> dietInfos, EdiblesManager.FoodInfo foodInfo, Tag poopTag, float dailyCalories, float howManyKgOfPoopForDailyCalories = 0f, string diseaseId = "", float diseasePerKg = 0f)
		{
			float caloriesPerUnit = foodInfo.CaloriesPerUnit;
			float num = dailyCalories / caloriesPerUnit;
			float produced_conversion_rate = 1f / (num / howManyKgOfPoopForDailyCalories);
			dietInfos.Add(string.IsNullOrEmpty(diseaseId) ? new Diet.Info(new HashSet<Tag>(new Tag[]
			{
				new Tag(foodInfo.Id)
			}), poopTag, caloriesPerUnit, produced_conversion_rate, null, 0f, false, false) : new Diet.Info(new HashSet<Tag>(new Tag[]
			{
				new Tag(foodInfo.Id)
			}), poopTag, caloriesPerUnit, produced_conversion_rate, diseaseId, diseasePerKg, false, false));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000290C File Offset: 0x00000B0C
		public static GameObject SetupPooplessDiet(GameObject prefab, List<Diet.Info> dietInfos)
		{
			Diet diet = new Diet(dietInfos.ToArray());
			prefab.AddOrGetDef<CreatureCalorieMonitor.Def>().diet = diet;
			prefab.AddOrGetDef<SolidConsumerMonitor.Def>().diet = diet;
			return prefab;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002944 File Offset: 0x00000B44
		public static GameObject SetupDiet(GameObject prefab, List<Diet.Info> dietInfos, float referenceCaloriesPerKg, float minPoopSizeInKg)
		{
			Diet diet = new Diet(dietInfos.ToArray());
			CreatureCalorieMonitor.Def def = prefab.AddOrGetDef<CreatureCalorieMonitor.Def>();
			def.diet = diet;
			def.minPoopSizeInCalories = referenceCaloriesPerKg * minPoopSizeInKg;
			prefab.AddOrGetDef<SolidConsumerMonitor.Def>().diet = diet;
			return prefab;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002988 File Offset: 0x00000B88
		public static List<Diet.Info> CreateFoodDiet(Tag poopTag, float calPerDay, float poopKgPerDay)
		{
			List<Diet.Info> list = new List<Diet.Info>();
			foreach (EdiblesManager.FoodInfo foodInfo in EdiblesManager.GetAllFoodTypes())
			{
				bool flag = (double)foodInfo.CaloriesPerUnit > 0.0;
				if (flag)
				{
					CritterDietUtils.AddToDiet(list, foodInfo, poopTag, calPerDay, poopKgPerDay, "", 0f);
				}
			}
			return list;
		}
	}
}
