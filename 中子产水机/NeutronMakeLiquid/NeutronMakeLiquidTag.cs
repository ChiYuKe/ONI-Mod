using KSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static ComplexRecipe.RecipeElement;
using static STRINGS.ELEMENTS;
using static STRINGS.ROOMS.DETAILS;

namespace ElementConvertTag.ElementConvertTag
{

    public class NeutronMakeLiquidTag 
    {
        public static void ConfgiureRecipes()
        {
            Tag tag1 = SimHashes.Graphite.CreateTag();//石墨
            Tag tag2 = SimHashes.Diamond.CreateTag();//钻石
            Tag tag3 = SimHashes.Carbon.CreateTag();//碳
            Tag tag4 = SimHashes.RefinedCarbon.CreateTag();//精炼碳
            Tag tag5 = SimHashes.Unobtanium.CreateTag();//中子物质
            Tag tag6 = SimHashes.Lime.CreateTag();//石灰
            Tag tag7 = SimHashes.SedimentaryRock.CreateTag();//沉积岩
            Tag tag8 = SimHashes.IgneousRock.CreateTag();//火成岩
            Tag tag9 = SimHashes.DepletedUranium.CreateTag(); // 贫铀
            Tag tag10 = SimHashes.EnrichedUranium.CreateTag();//浓缩铀
            Tag tag11 = SimHashes.Cobalt.CreateTag();//钴
            Tag tag12 = SimHashes.Phosphorus.CreateTag(); //精炼磷
            Tag tag13 = SimHashes.DirtyWater.CreateTag();//污染水
            Tag tag14 = SimHashes.Dirt.CreateTag();//泥土
            Tag tag15 = SimHashes.Salt.CreateTag();//盐
            Tag tag16 = SimHashes.Isoresin.CreateTag(); //异构树脂
            Tag tag17 = SimHashes.CrudeOil.CreateTag();//原油
            Tag tag18 = SimHashes.Polypropylene.CreateTag();//塑料
            Tag tag19 = SimHashes.Algae.CreateTag();//藻类
            Tag tag20 = SimHashes.Fertilizer.CreateTag();//肥料


            //需求物质
            ComplexRecipe.RecipeElement[] array = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag2, 1f),
                new ComplexRecipe.RecipeElement(tag3, 99f),
                new ComplexRecipe.RecipeElement(tag5, 0.01f)
            };
            //产出物质
            ComplexRecipe.RecipeElement[] array2 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag1, 10f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
                new ComplexRecipe.RecipeElement(tag4, 90f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
            };

            string obsolete_id = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag1);
            string text = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array, array2);
            ComplexRecipe complexRecipe = new ComplexRecipe(text, array, array2);
            complexRecipe.time = 20f;//这个材料的加工时间
            complexRecipe.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Carbon).name, ElementLoader.FindElementByHash(SimHashes.Graphite).name);
            complexRecipe.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id, text);




            
            
            ComplexRecipe.RecipeElement[] array3 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag3, 5f),
                new ComplexRecipe.RecipeElement(tag7, 150f),
                new ComplexRecipe.RecipeElement(tag8, 45f)
            };
            ComplexRecipe.RecipeElement[] array4 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag6, 200f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
                new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false)
            };
            string obsolete_id2 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag6);
            string text2 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array3, array4);
            ComplexRecipe complexRecipe2 = new ComplexRecipe(text2, array3, array4);
            complexRecipe2.time = 20f;
            complexRecipe2.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.SedimentaryRock).name, ElementLoader.FindElementByHash(SimHashes.Lime).name);
            complexRecipe2.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe2.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id2, text2);




           
            ComplexRecipe.RecipeElement[] array5 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag9, 110f),
                new ComplexRecipe.RecipeElement(tag11, 90f),
            };
            ComplexRecipe.RecipeElement[] array6 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag10, 200f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
                new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false)
            };
            string obsolete_id3 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag10);
            string text3 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array5, array6);
            ComplexRecipe complexRecipe3 = new ComplexRecipe(text3, array5, array6);
            complexRecipe3.time = 18f;
            complexRecipe3.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.DepletedUranium).name, ElementLoader.FindElementByHash(SimHashes.EnrichedUranium).name);
            complexRecipe3.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe3.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id3, text3);




           
            ComplexRecipe.RecipeElement[] array7 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag13, 200f),
                new ComplexRecipe.RecipeElement(tag14, 60f),
                new ComplexRecipe.RecipeElement(tag15, 40f)
            };
            ComplexRecipe.RecipeElement[] array8 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag12, 300f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false),
                new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false)
            };
            string obsolete_id4 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag10);
            string text4 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array7, array8);
            ComplexRecipe complexRecipe4 = new ComplexRecipe(text4, array7, array8);
            complexRecipe4.time = 18f;
            complexRecipe4.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.DirtyWater).name, ElementLoader.FindElementByHash(SimHashes.Phosphorus).name);
            complexRecipe4.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe4.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id4, text4);




            ComplexRecipe.RecipeElement[] array9 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag18, 250f),
                new ComplexRecipe.RecipeElement(tag17, 50f),
                new ComplexRecipe.RecipeElement(tag5, 0.01f)
            };
            ComplexRecipe.RecipeElement[] array10 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag16, 300f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
                //new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false)
            };
            string obsolete_id5 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag10);
            string text5 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array9, array10);
            ComplexRecipe complexRecipe5 = new ComplexRecipe(text5, array9, array10);
            complexRecipe5.time = 20f;
            complexRecipe5.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Polypropylene).name, ElementLoader.FindElementByHash(SimHashes.Isoresin).name);
            complexRecipe5.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe5.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id5, text5);





            Tag niobium = SimHashes.Niobium.CreateTag(); //铌
            Tag steel = SimHashes.Steel.CreateTag();//钢
            Tag tungsten = SimHashes.Tungsten.CreateTag();//钨

            ComplexRecipe.RecipeElement[] array11 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(steel, 200f),
                new ComplexRecipe.RecipeElement(tungsten, 100f),
                new ComplexRecipe.RecipeElement(tag5, 0.01f)
            };
            ComplexRecipe.RecipeElement[] array12 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(niobium, 300f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false),
                //new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false)
            };
            string obsolete_id6 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag10);
            string text6 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array11, array12);
            ComplexRecipe complexRecipe6 = new ComplexRecipe(text6, array11, array12);
            complexRecipe6.time = 20f;
            complexRecipe6.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Steel).name, ElementLoader.FindElementByHash(SimHashes.Niobium).name);
            complexRecipe6.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe6.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id6, text6);




         

            ComplexRecipe.RecipeElement[] array13 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag20, 20f),
                new ComplexRecipe.RecipeElement(tag8, 300f),
                new ComplexRecipe.RecipeElement(tag19, 80f)
            };
            ComplexRecipe.RecipeElement[] array14 = new ComplexRecipe.RecipeElement[]
            {
                new ComplexRecipe.RecipeElement(tag14, 400f, ComplexRecipe.RecipeElement.TemperatureOperation.AverageTemperature, false),
                new ComplexRecipe.RecipeElement(tag5, 0.01f, ComplexRecipe.RecipeElement.TemperatureOperation.Heated, false)
            };
            string obsolete_id7 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_NeutronMakeLiquid", tag10);
            string text7 = ComplexRecipeManager.MakeRecipeID("MyMod_NeutronMakeLiquid", array13, array14);
            ComplexRecipe complexRecipe7 = new ComplexRecipe(text7, array13, array14);
            complexRecipe7.time = 25f;
            complexRecipe7.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.IgneousRock).name, ElementLoader.FindElementByHash(SimHashes.Dirt).name);
            complexRecipe7.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_NeutronMakeLiquid")
            };
            complexRecipe7.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id7, text7);
        }
    }
}
