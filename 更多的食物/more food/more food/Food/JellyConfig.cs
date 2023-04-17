using CaiLib.Utils;
using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace more_food
{
    public class JellyConfig : IEntityConfig
    {
        //果冻
        //Grid.SceneLayer.Front 图层
        public const string ID = "Jelly";
        public ComplexRecipe Recipe;

        public GameObject CreatePrefab()
        {
            //创建一个新的松散实体模板，指定名称、描述、质量、动画、碰撞形状、质量等信息。
            GameObject template = EntityTemplates.CreateLooseEntity(ID, UI.FormatAsLink(STRINGSS.FOOD.JELLY_NAME, "Jelly"), STRINGSS.DESC.JELLY_DESC, 1f, false,
                Assets.GetAnim("Jelly_kanim"), "object", Grid.SceneLayer.Front, EntityTemplates.CollisionShape.RECTANGLE, 0.3f, 0.4f, true, 0, SimHashes.Creature, null);
            //创建一个新的食品信息对象，其中包括食物名称、卡路里、热量、饱和度、口感等信息。
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo("Jelly", "", 2400000f, 5, 255.15f, 277.15f, 2400f, true).AddEffects(new List<string>
            {
                 "GoodEats",
            }, DlcManager.AVAILABLE_EXPANSION1_ONLY);

            //扩展为一种食品，并将食品信息对象传递给它。
            GameObject result = EntityTemplates.ExtendEntityToFood(template, foodInfo);
            //配方
            this.Recipe = RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(SwampFruitConfig.ID, 1f),//沼泽果
                new ComplexRecipe.RecipeElement("Sucrose", 1f),//蔗糖
                new ComplexRecipe.RecipeElement("BeanPlantSeed", 1f),//小吃豆
            },
            new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("Jelly", 1f)
            },
            "GourmetCookingStation", 25f, STRINGSS.FOOD.JELLY_NAME, ComplexRecipe.RecipeNameDisplay.Result, 120, null);
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
