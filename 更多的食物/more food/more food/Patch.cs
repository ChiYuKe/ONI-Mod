using CaiLib.Utils;
using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_food
{
    public class More_foodPatch
    {
        [HarmonyPatch(typeof(EntityConfigManager))]
        [HarmonyPatch("LoadGeneratedEntities")]
        public class EntityConfigManager_LoadGeneratedEntities_Patch
        {
            public static void Prefix()
            {

                StringUtils.AddFoodStrings("BunnyRoll", STRINGSS.FOOD.BUNNYROLL_NAME, STRINGSS.DESC.BUNNYROLL_DESC, STRINGSS.RECIPE.BUNNYROLL_RECIPE);
                StringUtils.AddFoodStrings("MoonCake", STRINGSS.FOOD.MOONCAKE_NAME, STRINGSS.DESC.MOONCAKE_DESC, STRINGSS.RECIPE.MOONCAKE_RECIPE);
                StringUtils.AddFoodStrings("Jelly", STRINGSS.FOOD.JELLY_NAME, STRINGSS.DESC.JELLY_DESC, STRINGSS.RECIPE.JELLY_RECIPE);
                StringUtils.AddFoodStrings("ShreddedPorkWithChili", STRINGSS.FOOD.SHREDDEDPORKWITHCHILI_NAME, STRINGSS.DESC.SHREDDEDPORKWITHCHILI_DESC, STRINGSS.RECIPE.SHREDDEDPORKWITHCHILI_RECIPE);
                StringUtils.AddFoodStrings("UB", STRINGSS.FOOD.UB_NAME, STRINGSS.FOOD.UB_MS, STRINGSS.FOOD.UB_WK);
            }
        }
    }
}
