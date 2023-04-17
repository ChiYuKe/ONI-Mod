using System;
using CaiLib.Utils;
using Dark_Moon_GalaxyTree;
using HarmonyLib;

namespace Dark_Moon_GalaxyTree
{
    public class Dark_Moon_GalaxyTreePatch
    {
        [HarmonyPatch(typeof(EntityConfigManager))]
        [HarmonyPatch("LoadGeneratedEntities")]
        public class EntityConfigManager_LoadGeneratedEntities_Patch
        {
            public static void Prefix()
            {
                StringUtils.AddPlantStrings("Dark_Moon_GalaxyTree", Strings.NAME3, Strings.DESCRIPTION3, Dark_Moon_GalaxyTreeConfig.DomesticatedDescription);
                StringUtils.AddPlantSeedStrings("Dark_Moon_GalaxyTree", Strings.SEEDNAME, Dark_Moon_GalaxyTreeConfig.SeedDescription);
                StringUtils.AddFoodStrings("Nwe_Dark_Moon_GalaxyFruit", Strings.NAME1, Strings.DESCRIPTION1, Strings.RECIPE);
                StringUtils.AddFoodStrings(Dark_Moon_GalaxyFruitConfig.Id, Strings.NAME, Strings.DESCRIPTION, null);
                PlantUtils.AddCropType(Dark_Moon_GalaxyFruitConfig.Id, 15f, 5);
            }
        }

        [HarmonyPatch(typeof(KilnConfig))]
        [HarmonyPatch("ConfgiureRecipes")]
        public class 窑炉
        {
            public static void Postfix()
            {
                RecipeUtils.AddComplexRecipe(
                new ComplexRecipe.RecipeElement[]
                {
                    new ComplexRecipe.RecipeElement("BasicSingleHarvestPlantSeed".ToTag(), 2f),
                    new ComplexRecipe.RecipeElement(BasicFabricConfig.ID.ToTag(), 3f)
                },
                new ComplexRecipe.RecipeElement[]
                {
                    new ComplexRecipe.RecipeElement(TagManager.Create("Dark_Moon_GalaxyTreeSeed"), 1f)
                },
                "Kiln", 30f, Strings.DESCRIPTION4, ComplexRecipe.RecipeNameDisplay.Result, 1000, null
                );
            }
        }


        [HarmonyPatch(typeof(SupermaterialRefineryConfig))]
        [HarmonyPatch("ConfigureBuildingTemplate")]
        public class 分子熔炉
        {
           
            public static void Postfix()
            {
                RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
                {
                    new ComplexRecipe.RecipeElement("BasicSingleHarvestPlantSeed".ToTag(), 1f),
                    new ComplexRecipe.RecipeElement(BasicFabricConfig.ID.ToTag(), 1f)
                }, 
                new ComplexRecipe.RecipeElement[]
                {
                    new ComplexRecipe.RecipeElement(TagManager.Create("Dark_Moon_GalaxyTreeSeed"), 1f)
                },
                "SupermaterialRefinery", 20f, Strings.DESCRIPTION4, ComplexRecipe.RecipeNameDisplay.Result, 1000, null);
            }
        }
    }
}
