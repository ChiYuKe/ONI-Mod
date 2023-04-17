using System;
using STRINGS;
using TUNING;
using UnityEngine;
using CaiLib.Utils;
using System.Collections.Generic;

namespace more_food
{
    public class BunnyRollConfig : IEntityConfig
    {
        //兔子卷
        //Grid.SceneLayer.Front 图层
        public const string ID = "BunnyRoll";
        public ComplexRecipe Recipe;

        public GameObject CreatePrefab()
        {
            //创建一个新的松散实体模板，指定名称、描述、质量、动画、碰撞形状、质量等信息。
            GameObject template = EntityTemplates.CreateLooseEntity(ID,UI.FormatAsLink(STRINGSS.FOOD.BUNNYROLL_NAME,"BunnyRoll"),STRINGSS.DESC.BUNNYROLL_DESC,1f,false,
                Assets.GetAnim("BunnyRoll_kanim"),"object",Grid.SceneLayer.Front, EntityTemplates.CollisionShape.CIRCLE, 0.4f, 0.4f, true,0,SimHashes.Creature, null);
            //创建一个新的食品信息对象，其中包括食物名称、卡路里、热量、饱和度、口感等信息。
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo("BunnyRoll", "", 4600000f, 2, 255.15f, 277.15f, 3600f, true);

            //扩展为一种食品，并将食品信息对象传递给它。
            GameObject result = EntityTemplates.ExtendEntityToFood(template, foodInfo);
            //配方
            this.Recipe = RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("ColdWheatSeed", 8f),//小麦
                new ComplexRecipe.RecipeElement("Sucrose", 1f),//蔗糖
                new ComplexRecipe.RecipeElement("BasicPlantFood", 1f),//米虱
            },
            new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("BunnyRoll", 1f)
            },
            "CookingStation", 25f, STRINGSS.FOOD.BUNNYROLL_NAME, ComplexRecipe.RecipeNameDisplay.Result, 120, null);
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
    }
}
