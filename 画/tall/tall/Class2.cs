using Database;
using HarmonyLib;
using PeterHan.PLib.Options;
using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Database.ArtableStages;
using static Database.PermitResources;

namespace tall
{
    [HarmonyPatch(typeof(Assets), "SubstanceListHookup")]
    public class Class2
    {
        //public static LocString NAME = UI.FormatAsLink("妃咲", "ART_TALL_F");
        public static LocString DESC = "A moody study of the renowned tunneler.";
        public static void Postfix()
        {
           Infos = new ArtableStages.Info[]//妃咲
            {
               // new ArtableStages.Info("Canvas_Average", UI.FormatAsLink("对他使用炎拳吧！", "ART_A"), BUILDINGS.PREFABS.CANVASTALL.FACADES.ART_TALL_G.DESC, PermitRarity.Decent, "move_map5_kanim","art_c", 15, true, "LookingGreat", "Canvas", "canvas"),
               // new ArtableStages.Info("Canvas_Bad",  UI.FormatAsLink("痛苦的奈尔思", "ART_A"), BUILDINGS.PREFABS.CANVAS.FACADES.ART_C.DESC, PermitRarity.Universal, "move_map3_kanim",  "art_a", 5, false, "LookingUgly", "Canvas", "canvas"),
              //  new ArtableStages.Info("Canvas_Good", UI.FormatAsLink("花", "ART_A"), BUILDINGS.PREFABS.CANVAS.FACADES.ART_C.DESC, PermitRarity.Universal, "move_map4_kanim", "art_c", 15, true, "LookingGreat", "Canvas", "canvas"),
               // new ArtableStages.Info("Canvas_Good2", BUILDINGS.PREFABS.CANVAS.FACADES.ART_D.NAME, BUILDINGS.PREFABS.CANVAS.FACADES.ART_D.DESC, PermitRarity.Universal, "painting_art_d_kanim", "art_d", 15, true, "LookingGreat", "Canvas", "canvas"),
               // new ArtableStages.Info("Canvas_Good3", BUILDINGS.PREFABS.CANVAS.FACADES.ART_E.NAME, BUILDINGS.PREFABS.CANVAS.FACADES.ART_E.DESC, PermitRarity.Universal, "painting_art_e_kanim", "art_e", 15, true, "LookingGreat", "Canvas", "canvas"),
               // new ArtableStages.Info("Canvas_Good4", BUILDINGS.PREFABS.CANVAS.FACADES.ART_F.NAME, BUILDINGS.PREFABS.CANVAS.FACADES.ART_F.DESC, PermitRarity.Universal, "painting_art_f_kanim", "art_f", 15, true, "LookingGreat", "Canvas", "canvas"),
                //new ArtableStages.Info("Canvas_Good5", BUILDINGS.PREFABS.CANVAS.FACADES.ART_G.NAME, BUILDINGS.PREFABS.CANVAS.FACADES.ART_G.DESC, PermitRarity.Universal, "painting_art_g_kanim", "art_g", 15, true, "LookingGreat", "Canvas", "canvas"),
                //new ArtableStages.Info("Canvas_Good6", BUILDINGS.PREFABS.CANVAS.FACADES.ART_H.NAME, BUILDINGS.PREFABS.CANVAS.FACADES.ART_H.DESC, PermitRarity.Universal, "painting_art_h_kanim", "art_h", 15, true, "LookingGreat", "Canvas", "canvas"),
                new ArtableStages.Info("妃咲", UI.FormatAsLink("妃咲", "ART_A"), BUILDINGS.PREFABS.CANVASTALL.FACADES.ART_TALL_A.DESC, PermitRarity.Universal, "move_map_h2_kanim",  "art_b", 10, false, "LookingOkay", "MyMod_CanvasTall", "canvas"),
                new ArtableStages.Info("霜星",UI.FormatAsLink("霜星", "ART_A"), BUILDINGS.PREFABS.CANVASTALL.FACADES.ART_TALL_C.DESC, PermitRarity.Universal, "move_map_h3_kanim",  "art_a", 5, false, "LookingUgly", "MyMod_CanvasTall", "canvas"),

               


            };
        }
    }
}
