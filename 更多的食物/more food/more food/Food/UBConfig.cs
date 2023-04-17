using CaiLib.Utils;
using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace more_food
{
    public class UBConfig : IEntityConfig
    {
        //辣椒肉丝
        //Grid.SceneLayer.Front 图层
        public const string ID = "UB";
        public ComplexRecipe Recipe;
       


        public GameObject CreatePrefab()
        {
            //创建一个新的松散实体模板，指定名称、描述、质量、动画、碰撞形状、质量等信息。
            GameObject template = EntityTemplates.CreateLooseEntity(ID, UI.FormatAsLink(STRINGSS.FOOD.UB_NAME, "UB"), STRINGSS.FOOD.UB_NAME, 1f, false,
                Assets.GetAnim("UB_kanim"), "object", Grid.SceneLayer.Front, EntityTemplates.CollisionShape.RECTANGLE, 0.6f, 0.4f, true, 0, SimHashes.Creature, null);
            //创建一个新的食品信息对象，其中包括食物名称、卡路里、热量、饱和度、口感等信息。
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo("UB", "", 10f, -1, 255.15f, 277.15f, 4800f, false).AddEffects(new List<string>
            {
                 "HotStuff",
                 "GoodEats",
                 "SeafoodRadiationResistance"
            }, DlcManager.AVAILABLE_EXPANSION1_ONLY);

            //扩展为一种食品，并将食品信息对象传递给它。
            GameObject result = EntityTemplates.ExtendEntityToFood(template, foodInfo);
            //配方
            this.Recipe = RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("UraniumOre", 5f),//铀
                
            },
            new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("UB", 1f)
            },
            "CookingStation", 100f,STRINGSS.FOOD.UB_NAME, ComplexRecipe.RecipeNameDisplay.Result, 120, null);
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
