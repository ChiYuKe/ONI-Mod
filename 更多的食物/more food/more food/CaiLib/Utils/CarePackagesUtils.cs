using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;

namespace CaiLib.Utils
{
	// Token: 0x0200000A RID: 10
	public class CarePackagesUtils
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002778 File Offset: 0x00000978
		public static void AddCarePackage(ref Immigration immigration, string objectId, float amount, Func<bool> requirement = null)
		{
			Traverse traverse = Traverse.Create(immigration).Field("carePackages");
			List<CarePackageInfo> list = traverse.GetValue<CarePackageInfo[]>().ToList<CarePackageInfo>();
			list.Add(new CarePackageInfo(objectId, amount, requirement));
			traverse.SetValue(list.ToArray());
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027C0 File Offset: 0x000009C0
		public static bool CycleCondition(int cycle)
		{
			return GameClock.Instance.GetCycle() >= cycle;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000027E4 File Offset: 0x000009E4
		public static bool DiscoveredCondition(Tag tag)
		{
			return DiscoveredResources.Instance.IsDiscovered(tag);
		}
	}
}
