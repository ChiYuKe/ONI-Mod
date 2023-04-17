using System;
using CaiLib.Utils;
using STRINGS;
using UnityEngine;

namespace Dark_Moon_GalaxyTree
{
    public class Nwe_Dark_Moon_GalaxyFruit : IEntityConfig
    {
        //氧氧果加工产品
        public GameObject CreatePrefab()
        {
            GameObject template = EntityTemplates.CreateLooseEntity(
                "Nwe_Dark_Moon_GalaxyFruit", 
                UI.FormatAsLink(Strings.NAME1, 
                "Nwe_Dark_Moon_GalaxyFruit"),
                Strings.DESCRIPTION1, 
                1f,
                false, 
                Assets.GetAnim("New_Dark_Moon_GalaxyFruit_kanim"),
                "object",
                Grid.SceneLayer.Front,
                EntityTemplates.CollisionShape.RECTANGLE,
                0.8f,
                0.7f,
                true,
                0,
                SimHashes.Creature,
                null);
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo("Nwe_Dark_Moon_GalaxyFruit", "", 10000000f, 6, 255.15f, 277.15f, 15000f, true);
            GameObject result = EntityTemplates.ExtendEntityToFood(template, foodInfo);
            this.Recipe = RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(Dark_Moon_GalaxyFruitConfig.Id, 1f)
            }, new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("Nwe_Dark_Moon_GalaxyFruit", 1f)
            }, "GourmetCookingStation", 100f, Strings.RECIPE, ComplexRecipe.RecipeNameDisplay.Result, 120, null);
            return result;
        }

        public void OnPrefabInit(GameObject inst)
        {
        }

        public void OnSpawn(GameObject inst)
        {
        }

        public string[] GetDlcIds()
        {
            return DlcManager.AVAILABLE_ALL_VERSIONS;
        }


        public const string Id = "Nwe_Dark_Moon_GalaxyFruit";
        public ComplexRecipe Recipe;
    }
}
