using System;
using TUNING;

namespace CaiLib.Utils
{
	// Token: 0x0200000D RID: 13
	public class PlantUtils
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002A1D File Offset: 0x00000C1D
		public static void AddCropType(string cropId, float domesticatedGrowthTimeInCycles, int producedPerHarvest)
		{
			CROPS.CROP_TYPES.Add(new Crop.CropVal(cropId, domesticatedGrowthTimeInCycles * 600f, producedPerHarvest, true));
		}
	}
}
