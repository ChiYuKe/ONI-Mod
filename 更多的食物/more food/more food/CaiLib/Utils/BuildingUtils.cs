using System;

namespace CaiLib.Utils
{
	// Token: 0x02000009 RID: 9
	public static class BuildingUtils
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002749 File Offset: 0x00000949
		public static void AddBuildingToPlanScreen(HashedString category, string buildingId, string subCategory = "uncategorized", string addAfterBuildingId = null)
		{
			ModUtil.AddBuildingToPlanScreen(category, buildingId, subCategory, addAfterBuildingId, ModUtil.BuildingOrdering.After);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002757 File Offset: 0x00000957
		public static void AddBuildingToTechnology(string techId, string buildingId)
		{
			Db.Get().Techs.Get(techId).unlockedItemIDs.Add(buildingId);
		}
	}
}
