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

    public class ElementConvertTag 
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

            string obsolete_id = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag1);
            string text = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array, array2);
            ComplexRecipe complexRecipe = new ComplexRecipe(text, array, array2);
            complexRecipe.time = 20f;//这个材料的加工时间
            complexRecipe.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Carbon).name, ElementLoader.FindElementByHash(SimHashes.Graphite).name);
            complexRecipe.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id2 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag6);
            string text2 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array3, array4);
            ComplexRecipe complexRecipe2 = new ComplexRecipe(text2, array3, array4);
            complexRecipe2.time = 20f;
            complexRecipe2.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.SedimentaryRock).name, ElementLoader.FindElementByHash(SimHashes.Lime).name);
            complexRecipe2.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id3 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag10);
            string text3 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array5, array6);
            ComplexRecipe complexRecipe3 = new ComplexRecipe(text3, array5, array6);
            complexRecipe3.time = 18f;
            complexRecipe3.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.DepletedUranium).name, ElementLoader.FindElementByHash(SimHashes.EnrichedUranium).name);
            complexRecipe3.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id4 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag10);
            string text4 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array7, array8);
            ComplexRecipe complexRecipe4 = new ComplexRecipe(text4, array7, array8);
            complexRecipe4.time = 18f;
            complexRecipe4.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.DirtyWater).name, ElementLoader.FindElementByHash(SimHashes.Phosphorus).name);
            complexRecipe4.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id5 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag10);
            string text5 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array9, array10);
            ComplexRecipe complexRecipe5 = new ComplexRecipe(text5, array9, array10);
            complexRecipe5.time = 20f;
            complexRecipe5.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Polypropylene).name, ElementLoader.FindElementByHash(SimHashes.Isoresin).name);
            complexRecipe5.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id6 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag10);
            string text6 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array11, array12);
            ComplexRecipe complexRecipe6 = new ComplexRecipe(text6, array11, array12);
            complexRecipe6.time = 20f;
            complexRecipe6.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.Steel).name, ElementLoader.FindElementByHash(SimHashes.Niobium).name);
            complexRecipe6.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
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
            string obsolete_id7 = ComplexRecipeManager.MakeObsoleteRecipeID("MyMod_ElementConvert", tag10);
            string text7 = ComplexRecipeManager.MakeRecipeID("MyMod_ElementConvert", array13, array14);
            ComplexRecipe complexRecipe7 = new ComplexRecipe(text7, array13, array14);
            complexRecipe7.time = 25f;
            complexRecipe7.description = string.Format(STRINGS.BUILDINGS.PREFABS.EGGCRACKER.RECIPE_DESCRIPTION, ElementLoader.FindElementByHash(SimHashes.IgneousRock).name, ElementLoader.FindElementByHash(SimHashes.Dirt).name);
            complexRecipe7.fabricators = new List<Tag>
            {
                TagManager.Create("MyMod_ElementConvert")
            };
            complexRecipe7.nameDisplay = ComplexRecipe.RecipeNameDisplay.Result;
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id7, text7);
        }
    }

    //下面的只是参照物，没有任何作用
    public enum SimHashess
    {
        AluminumGas = 100766521,
        CarbonDioxide = 1960575215,
        CarbonGas = -314016756,
        ChlorineGas = -1324664829,
        ContaminatedOxygen = 721531317,
        CopperGas = 1966552544,
        GoldGas = -805366663,
        Helium = -1554872654,
        Hydrogen = -1046145888,
        IronGas = 1541626289,
        CobaltGas = -1429687642,
        LeadGas = 905042813,
        MercuryGas = -839856666,
        Methane = -841236436,
        NiobiumGas = -1616033402,
        Fallout = 1000463219,
        Oxygen = -1528777920,
        PhosphorusGas = 1887387588,
        Propane = -1858722091,
        RockGas = -432557516,
        SaltGas = -1946026749,
        SourGas = -927923200,
        Steam = -899515856,
        SteelGas = -1406916018,
        SulfurGas = -2120504832,
        SuperCoolantGas = -3376362,
        TungstenGas = 431998133,
        EthanolGas = -756961258,
        Syngas = 1102028305,
        Brine = -324547888,
        Chlorine = -878033482,
        CrudeOil = -1412059381,
        DirtyWater = 1832607973,
        LiquidCarbonDioxide = -1526513293,
        LiquidHelium = -1934139602,
        LiquidHydrogen = -751997156,
        LiquidMethane = 371787440,
        LiquidOxygen = -1908044868,
        LiquidPhosphorus = 1323821489,
        LiquidPropane = -645698215,
        LiquidSulfur = -1108652427,
        Magma = -1075911705,
        Mercury = 1732126099,
        MoltenAluminum = -1637472877,
        MoltenCarbon = 505665536,
        MoltenCopper = 2128494380,
        MoltenGlass = -1312713527,
        MoltenGold = -1083496621,
        MoltenIron = 502659099,
        MoltenCobalt = -333255194,
        MoltenLead = -1558864561,
        MoltenNiobium = 1499134368,
        MoltenSalt = -422045879,
        MoltenSteel = 1459013976,
        MoltenTungsten = -509585641,
        MoltenUranium = 1937473860,
        Naphtha = 1157157570,
        NuclearWaste = -232430636,
        Petroleum = -486269331,
        Resin = -746800379,
        SaltWater = 1911997537,
        SuperCoolant = -123825053,
        ViscoGel = -1683093854,
        Water = 1836671383,
        Ethanol = -87974045,
        MoltenSyngas = 660593444,
        MoltenSucrose = 1318135165,
        Aerogel = -2070223827,
        Algae = -1870043872,
        Aluminum = 2108244480,
        AluminumOre = 167973730,
        Bitumen = 1433229102,
        BleachStone = -839728230,
        Brick = -325269471,
        BrineIce = -1561279013,
        Carbon = 947100397,
        CarbonFibre = 118518245,
        Cement = 1627140480,
        CementMix = 1668719292,
        Ceramic = -1467370314,
        Clay = 867327137,
        Copper = -1725038055,
        Creature = 976099455,
        CrushedIce = -2123557039,
        CrushedRock = -1714565729,
        Cuprite = -1736594426,
        DepletedUranium = 1064294988,
        Diamond = -2079931820,
        Dirt = 1624244999,
        DirtyIce = 1664334585,
        Electrum = 28407099,
        EnrichedUranium = -348942381,
        Fertilizer = -1396791454,
        FoolsGold = 2059777261,
        Fossil = 1757792140,
        Fullerene = 245514112,
        Glass = 623986332,
        Gold = -279785280,
        GoldAmalgam = 361868060,
        Granite = -105943486,
        Ice = 873952427,
        IgneousRock = -355957251,//火成岩
        Iron = 1306370440,
        IronOre = 1608833498,
        Cobalt = 108179667,
        Cobaltite = -1411918265,
        Isoresin = -2008682336,
        Katairite = 1071649902,
        Lead = -755153220,
        Lime = -721320011,
        MaficRock = 1282846257,
        Niobium = -1779895821,
        Corium = -220644613,
        Obsidian = -474151749,
        OxyRock = 1262005685,
        PhosphateNodules = -1901832310,
        Phosphorite = -877427037,
        Phosphorus = -220394187,
        Polypropylene = -1142341158,
        Radium = -47820500,
        RefinedCarbon = -902240476,
        Regolith = 1362238252,
        Rust = -233232444,
        Salt = 381665462,
        Sand = 381796644,
        SandCement = -1038746460,
        SandStone = 493438017,
        SedimentaryRock = 183408504,//沉积岩
        Slabs = 1412740729,
        Stag6Mold = -1153056158,
        Snow = 489261827,
        SolidCarbonDioxide = 83003332,
        SolidChlorine = -690060127,
        SolidCrudeOil = -1224086026,
        SolidHydrogen = -858172533,
        SolidMercury = -537625624,
        SolidMethane = 1183979137,
        SolidNaphtha = -1112594153,
        SolidOxygen = 973502379,
        SolidPetroleum = -473261502,
        SolidPropane = 166493482,
        SolidResin = 1376267226,
        SolidSuperCoolant = -389019570,
        SolidViscoGel = -1495120499,
        Steel = -899253461,
        Sulfur = -729385479,
        SuperInsulator = -1713958528,
        TempConductorSolid = 1559722904,
        ToxicSand = 869554203,
        Tungsten = -1058835580,
        Unobtanium = 1838482828,
        UraniumOre = 134298891,
        Wolframite = -1208854194,
        Yellowcake = -1624413844,
        SolidEthanol = 1937241528,
        SolidSyngas = -690658692,
        ToxicMud = 900133477,
        Mud = 908179228,
        Sucrose = -1960895024,
        Graphite = 878995724,
        SolidNuclearWaste = -497625153,
        Vacuum = 758759285,
        Void = -1456075980,
        COMPOSITION = -1021084918
    }

}
