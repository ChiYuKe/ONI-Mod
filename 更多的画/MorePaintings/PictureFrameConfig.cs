using System;
using System.Collections.Generic;
using TUNING;
using UnityEngine;
using static STRINGS.UI.STARMAP;

namespace more_paintings
{
	public class PictureFrameConfig : IBuildingConfig
	{
		public override BuildingDef CreateBuildingDef()
		{
            string id = "MorePaintings";
            int width = 2;
            int height = 3;
            string anim = "Setu_kanim";
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
            BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(id, width, height, anim, hitpoints, construction_time, construction_mass, construction_materials, melting_point, build_location_rule, new EffectorValues
            {
                amount = 30,
                radius = 6
            }, none, 0.2f);
            buildingDef.Floodable = false;
            buildingDef.SceneLayer = Grid.SceneLayer.InteriorWall;
            buildingDef.Overheatable = false;
            buildingDef.AudioCategory = "Metal";
            buildingDef.BaseTimeUntilRepair = -1f;
            buildingDef.ViewMode = OverlayModes.Decor.ID;
            buildingDef.DefaultAnimState = "off";
            buildingDef.PermittedRotations = PermittedRotations.FlipH;
            return buildingDef;
        }

		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }

        public override void DoPostConfigureComplete(GameObject go)
		{
			go.AddOrGet<SelectableSign>().AnimationNames = new List<string>
			{
				"00",
				"01",
				"02",
				"03",
				"04",
				"05",
				"06",
				"07",
				"08",
				"09",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21"
			};
		}

		public const string ID = "MorePaintings";

    }
}
