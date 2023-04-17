using System;
using STRINGS;
using UnityEngine;

namespace Dark_Moon_GalaxyTree
{
    //氧氧果配置
    public class Dark_Moon_GalaxyFruitConfig : IEntityConfig
    {

        public GameObject CreatePrefab()
        {
            GameObject template = EntityTemplates.CreateLooseEntity(
                Dark_Moon_GalaxyFruitConfig.Id,
                UI.FormatAsLink(Strings.NAME, 
                Dark_Moon_GalaxyFruitConfig.Id), 
                Strings.DESCRIPTION, 1f, false, 
                Assets.GetAnim("Dark_Moon_GalaxyFruit_kanim"), "object", 
                Grid.SceneLayer.Front, 
                EntityTemplates.CollisionShape.RECTANGLE,
                0.77f, 
                0.48f,
                true,
                0,
                SimHashes.Creature,
                null);
            EdiblesManager.FoodInfo foodInfo = new EdiblesManager.FoodInfo(Dark_Moon_GalaxyFruitConfig.Id, "", 6000000f, 0, 258.15f, 283.15f,30000f, true);
            GameObject gameObject = EntityTemplates.ExtendEntityToFood(template, foodInfo);

            Sublimates sublimates = gameObject.AddOrGet<Sublimates>();
            sublimates.spawnFXHash = SpawnFXHashes.OxygenEmissionBubbles;
            sublimates.info = new Sublimates.Info(0.001f, 0f, 0.8f, 0f, SimHashes.Oxygen, byte.MaxValue, 0);
            return gameObject;
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

        public static string Id = "PalmeraBerry";
        //public static string Name = "Palmera Berry";
        //public static string Description = "A toxic, non-edible bud that emits hydrogen.";
    }
}
