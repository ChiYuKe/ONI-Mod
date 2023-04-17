using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ResearchTypes;
using TUNING;
using UnityEngine;

namespace tall
{
    
    public class New_Painting_erect : IBuildingConfig
    {
        public static string ID = "MyMod_CanvasTall";
        public override BuildingDef CreateBuildingDef()
        {
            string id = "MyMod_CanvasTall";
            int width = 2;
            int height = 3;
            string anim = "move_map_kanim";
            int hitpoints = 30;
            float construction_time = 120f;
            float[] construction_mass = new float[]
            {
            400f,
            1f
            };
            string[] construction_materials = new string[]
            {
            "Metal",
            "BuildingFiber"
            };
            float melting_point = 1600f;
            BuildLocationRule build_location_rule = BuildLocationRule.Anywhere;
            EffectorValues none = NOISE_POLLUTION.NONE;
            BuildingDef def = BuildingTemplates.CreateBuildingDef(id, width, height, anim, hitpoints, construction_time, construction_mass, construction_materials, melting_point, build_location_rule, new EffectorValues
            {
                amount = 15,
                radius = 6
            }, none, 0.2f);
            def.Floodable = false;
            def.SceneLayer = Grid.SceneLayer.InteriorWall;
            def.Overheatable = false;
            def.AudioCategory = "Metal";
            def.BaseTimeUntilRepair = -1f;
            def.ViewMode = OverlayModes.Decor.ID;
            def.DefaultAnimState = "off";
            def.PermittedRotations = PermittedRotations.FlipH;
            return def;
        }

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<BuildingComplete>().isArtable = true;
            go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            SymbolOverrideControllerUtil.AddToPrefab(go);
        }
    }
}
