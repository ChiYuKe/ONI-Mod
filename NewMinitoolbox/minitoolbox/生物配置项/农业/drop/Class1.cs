using HarmonyLib;
using PeterHan.PLib.Options;
using System.Collections.Generic;
using TUNING;

namespace minitoolbox.Plant_Changes.Plant_Grow_Drop.drop
{
    [HarmonyPatch(typeof(Assets), "SubstanceListHookup")]
    public class Class1
    {
        
        private static void Postfix()
        {
            //乔木树
            CROPS.CROP_TYPES[0] = new Crop.CropVal("WoodLog", SingletonOptions<ConfigurationItem>.Instance.WoodLog_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.WoodLog_Harvest_Quantity, true);
            //米虱木
            CROPS.CROP_TYPES[1] = new Crop.CropVal("BasicPlantFood", SingletonOptions<ConfigurationItem>.Instance.BasicPlantFood_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.BasicPlantFood_Harvest_Quantity, true);
            //毛刺花
            CROPS.CROP_TYPES[2] = new Crop.CropVal(PrickleFruitConfig.ID, SingletonOptions<ConfigurationItem>.Instance.PrickleFruit_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.PrickleFruit_Harvest_Quantity, true);
            //沼泽笼
            CROPS.CROP_TYPES[3] = new Crop.CropVal(SwampFruitConfig.ID, SingletonOptions<ConfigurationItem>.Instance.SwampFruit_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.SwampFruit_Harvest_Quantity, true);
            //夜幕菇
            CROPS.CROP_TYPES[4] = new Crop.CropVal(MushroomConfig.ID, SingletonOptions<ConfigurationItem>.Instance.Mushroom_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.Mushroom_Harvest_Quantity, true);
            //冰霜小麦
            CROPS.CROP_TYPES[5] = new Crop.CropVal("ColdWheatSeed", SingletonOptions<ConfigurationItem>.Instance.ColdWheatSeed_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.ColdWheatSeed_Harvest_Quantity, true);
            //火椒藤
            CROPS.CROP_TYPES[6] = new Crop.CropVal(SpiceNutConfig.ID, SingletonOptions<ConfigurationItem>.Instance.SpiceNut_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.SpiceNut_Harvest_Quantity, true);
            //顶针芦苇
            CROPS.CROP_TYPES[7] = new Crop.CropVal(BasicFabricConfig.ID, SingletonOptions<ConfigurationItem>.Instance.BasicFabric_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.BasicFabric_Harvest_Quantity, true);
            //芳香百合
            CROPS.CROP_TYPES[8] = new Crop.CropVal(SwampLilyFlowerConfig.ID, SingletonOptions<ConfigurationItem>.Instance.SwampLilyFlower_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.SwampLilyFlower_Harvest_Quantity, true);
            //释气草
            CROPS.CROP_TYPES[9] = new Crop.CropVal("GasGrassHarvested", SingletonOptions<ConfigurationItem>.Instance.GasGrassHarvested_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.GasGrassHarvested_Harvest_Quantity, true);
            //水草
            CROPS.CROP_TYPES[10] = new Crop.CropVal("Lettuce", SingletonOptions<ConfigurationItem>.Instance.Lettuce_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.Lettuce_Harvest_Quantity, true);
            //小吃芽
            CROPS.CROP_TYPES[11] = new Crop.CropVal("BeanPlantSeed", SingletonOptions<ConfigurationItem>.Instance.BeanPlantSeed_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.BeanPlantSeed_Harvest_Quantity, true);
            //土星动物蒱草
            CROPS.CROP_TYPES[13] = new Crop.CropVal("PlantMeat", SingletonOptions<ConfigurationItem>.Instance.PlantMeat_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.PlantMeat_Harvest_Quantity, true);
            //贫瘠虫果
            CROPS.CROP_TYPES[14] = new Crop.CropVal("WormBasicFruit", SingletonOptions<ConfigurationItem>.Instance.WormBasicFruit_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.WormBasicFruit_Harvest_Quantity, true);
            //虫果
            CROPS.CROP_TYPES[15] = new Crop.CropVal("WormSuperFruit", SingletonOptions<ConfigurationItem>.Instance.WormSuperFruit_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.WormSuperFruit_Harvest_Quantity, true);
            //沙盐藤
            CROPS.CROP_TYPES[16] = new Crop.CropVal(SimHashes.Salt.ToString(), SingletonOptions<ConfigurationItem>.Instance.Salt_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.Salt_Harvest_Quantity, true);
            //仙水掌
            CROPS.CROP_TYPES[17] = new Crop.CropVal(SimHashes.Water.ToString(), SingletonOptions<ConfigurationItem>.Instance.Water_Growth_Time, SingletonOptions<ConfigurationItem>.Instance.Water_Harvest_Quantity, true);
        }
    }
}
