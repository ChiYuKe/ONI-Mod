using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;
using TMPro;

namespace RDMachine
{
    public class ChaoticMatterGeneratorConfig : IBuildingConfig
    {
        public const string ID = "ChaoticMatterGenerator";
        public override BuildingDef CreateBuildingDef()
        {
            BuildingDef obj = BuildingTemplates.CreateBuildingDef("ChaoticMatterGenerator", 2, 2, "waterpurifier_kanim", 100, 30f, BUILDINGS.CONSTRUCTION_MASS_KG.TIER3, MATERIALS.ALL_METALS, 800f, BuildLocationRule.OnFloor, noise: NOISE_POLLUTION.NOISY.TIER3, decor: BUILDINGS.DECOR.PENALTY.TIER2);
            obj.RequiresPowerInput = true;
            obj.EnergyConsumptionWhenActive = 120f;
            obj.ExhaustKilowattsWhenActive = 0f;
            obj.SelfHeatKilowattsWhenActive = 4f;
            //obj.InputConduitType = ConduitType.Liquid;
            //obj.OutputConduitType = ConduitType.Liquid;
            obj.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 1));
            obj.ViewMode = OverlayModes.Power.ID;
            obj.AudioCategory = "HollowMetal";
            obj.PowerInputOffset = new CellOffset(0, 0);
            //obj.UtilityInputOffset = new CellOffset(-1, 2);
            //obj.UtilityOutputOffset = new CellOffset(2, 2);
            obj.PermittedRotations = PermittedRotations.FlipH;
            GeneratedBuildings.RegisterWithOverlay(OverlayScreen.WireIDs, "ChaoticMatterGenerator");
            return obj;
        }

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.IndustrialMachinery);
            Storage storage = BuildingTemplates.CreateDefaultStorage(go);
            storage.SetDefaultStoredItemModifiers(Storage.StandardSealedStorage);
            storage.capacityKg = 20f;
            /*
            Electrolyzer electrolyzer = go.AddOrGet<Electrolyzer>();
            electrolyzer.maxMass = float.PositiveInfinity;
            electrolyzer.hasMeter = true;
            electrolyzer.emissionOffset = new CellOffset(0, 0);
            */
            ElementDropper elementDropper = go.AddComponent<ElementDropper>();
            elementDropper.emitMass = 10f;
            elementDropper.emitTag = new Tag("Unobtanium");
            elementDropper.emitOffset = new Vector3(0f, 1f, 0f);
            ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
            /*
            elementConverter.consumedElements = new ElementConverter.ConsumedElement[] {
                new ElementConverter.ConsumedElement(SimHashes.Vacuum.CreateTag(), 0f)
            };
            */
            ElementConverter.OutputElement element = new ElementConverter.OutputElement(5f, SimHashes.Unobtanium, 0f, storeOutput: true);
            elementConverter.outputElements = new ElementConverter.OutputElement[] { element };
            //Prioritizable.AddRef(go);
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            //go.AddOrGet<LogicOperationalController>();
            //go.AddOrGetDef<PoweredActiveController.Def>();
            //go.GetComponent<KPrefabID>().AddTag(GameTags.OverlayBehindConduits);
        }

        
    }
}
