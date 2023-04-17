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
    public class ShreddedPorkWithChiliConfig : IEntityConfig
    {
        //辣椒肉丝
        //Grid.SceneLayer.Front 图层
        public const string ID = "ShreddedPorkWithChili";
        public ComplexRecipe Recipe;

        public GameObject CreatePrefab()
        {
            //创建一个新的松散实体模板，指定名称、描述、质量、动画、碰撞形状、质量等信息。
            GameObject template = EntityTemplates.CreateLooseEntity(ID, UI.FormatAsLink(STRINGSS.FOOD.SHREDDEDPORKWITHCHILI_NAME, "ShreddedPorkWithChili"), STRINGSS.DESC.SHREDDEDPORKWITHCHILI_DESC, 1f, false,
                Assets.GetAnim("ShreddedPorkWithChili_kanim"), "object", Grid.SceneLayer.Front, EntityTemplates.CollisionShape.RECTANGLE, 0.6f, 0.4f, true, 0, SimHashes.Creature, null);
            //创建一个新的食品信息对象，其中包括食物名称、卡路里、热量、饱和度、口感等信息。
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo("ShreddedPorkWithChili", "", 8800000f, 4, 255.15f, 277.15f, 4800f, true).AddEffects(new List<string>
            {
                 "HotStuff",
            }, DlcManager.AVAILABLE_EXPANSION1_ONLY);

            //扩展为一种食品，并将食品信息对象传递给它。
            GameObject result = EntityTemplates.ExtendEntityToFood(template, foodInfo);
            //配方
            this.Recipe = RecipeUtils.AddComplexRecipe(new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("ColdWheatSeed", 1f),//小麦
                new ComplexRecipe.RecipeElement(SpiceNutConfig.ID, 1f),//火椒粒
                new ComplexRecipe.RecipeElement("CookedMeat", 1.6f),//烤肉  
                new ComplexRecipe.RecipeElement("Lettuce", 1f),//海生菜
                
            },
            new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement("ShreddedPorkWithChili", 1f)
            },
            "CookingStation", 35f, STRINGSS.FOOD.SHREDDEDPORKWITHCHILI_NAME, ComplexRecipe.RecipeNameDisplay.Result, 120, null);
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
