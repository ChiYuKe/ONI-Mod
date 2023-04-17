using Newtonsoft.Json;
using PeterHan.PLib.Options;
using System;


namespace minitoolbox
{
    [JsonObject(MemberSerialization.OptIn)]
    [ConfigFile("minitoolbox.json", true, true)]
    [RestartRequired]
    public class ConfigurationItem : SingletonOptions<ConfigurationItem>
    {

        [Option("电池舱不漏电", "", null, Format = "F0")]
        [JsonProperty]
        public bool 电池舱 { get; set; }

        [Option("挖掘掉落的倍率", "Dirt block drop rate", null, Format = "F0")]
        //区间是0.5到5倍，0.5是缺氧默认的
        [Limit(0.5, 5)]
        [JsonProperty]
        public float HightDiggingRatio_Magnification { get; set; }
        

        [Option("擦水无视液体质量", "Will the electrolyzer flood", null, Format = "F0")]
        [JsonProperty]
        public bool Mop_Max { get; set; }

        [Option("冰箱容量, kg", "refrigerator capacity，kg", "容量配置", Format = "F0")]
        [Limit(100.0, 1000000.0)]
        [JsonProperty]
        public float Refrigerator_Capacity { get; set; }

        [Option("冰箱活动时的功率, W", "Energy consumption when the refrigerator is active，w", "功率配置", Format = "F0")]
        [Limit(1,120)]
        [JsonProperty]
        public float Refrigerator_Electricity { get; set; }

        [Option("冰箱不会被淹没", "Will the refrigerator be flooded", "建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool Refrigerator_Submerge { get; set; }

        [Option("冰箱不会过热", "Will the refrigerator overheat", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool Refrigerator_Overheat { get; set; }

        [Option("储物箱容量，kg", "storage box capacity，kg", "容量配置", Format = "F0")]
        [Limit(2000.0, 10000000.0)]
        [JsonProperty]
        public float StorageBox_Capacity { get; set; }

        [Option("储物箱不会过热", "Will the storage box overheat", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool StorageBox_Overheat { get; set; }

        [Option("气库容量，kg", "Gas storage capacity，kg", "容量配置", Format = "F0")]
        [Limit(150, 100000.0)]
        [JsonProperty]
        public float GasReservoir_Capacity { get; set; }

        [Option("气库不需要地基", "Does the gas storage need a foundation?", null, Format = "F0")]
        [JsonProperty]
        public bool GasReservoir_foundation { get; set; }

        [Option("气库不会过热", "Will the gas storage overheat", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool GasReservoir_Overheat { get; set; }

        [Option("液库容量，kg", "Liquid storage capacity，kg", "容量配置", Format = "F0")]
        [Limit(5000, 100000.0)]
        [JsonProperty]
        public float LiquidReservoir_Capacity { get; set; }

        [Option("液库不需要地基", "Does the liquid reservoir need a foundation?", null, Format = "F0")]
        [JsonProperty]
        public bool LiquidReservoir_foundation { get; set; }

        [Option("液库不会过热", "Will the liquid reservoir overheat?", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidReservoir_Overheat { get; set; }

        [Option("电线负载，kW", "wire load, kw", "导线配置", Format = "F0")]
        [Limit(1, 1000.0)]
        [JsonProperty]
        public float ElectricWire_Thinline { get; set; }

        [Option("导线负载，kW", "wire load，kw", "导线配置", Format = "F0")]
        [Limit(2, 1000.0)]
        [JsonProperty]
        public float ElectricWire_wire { get; set; }

        [Option("高负荷电线负载，kW", "High load wire load，kw", "导线配置", Format = "F0")]
        [Limit(20, 1000.0)]
        [JsonProperty]
        public float ElectricWire_Thickline { get; set; }

        [Option("高负荷导线负载，kW", "High load wire load， kw", "导线配置", Format = "F0")]
        [Limit(50, 1000.0)]
        [JsonProperty]
        public float ElectricWire_HighVoltageline { get; set; }

        [Option("金属精炼器的容量，kg", "metal refiner capacity， kg", "容量配置", Format = "F0")]
        [Limit(800, 4000)]
        [JsonProperty]
        public float MetalRefinery_Capacity { get; set; }
        
        [Option("金属精炼器功率，w", "metal refiner power， w", "功率配置", Format = "F0")]
        [Limit(1, 1200)]
        [JsonProperty]
        public float MetalRefinery_Electricity { get; set; }

        [Option("金属精炼器不会加热冷却剂", "Does the metal refiner heat the coolant", null, Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Heating { get; set; }

        [Option("金属精炼器不会自热", "Does the Metal Refiner self-heat?", "建筑自热配置")]
        [JsonProperty]
        public bool MetalRefinery_SelfHeating { get; set; }

        [Option("金属精炼器不会淹没", "metal refiner will drown", "建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Submerge { get; set; }

        [Option("金属精炼器不会过热", "metal refiner will overheat", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Overheat { get; set; }
       
        [Option("金属精炼器不需要复制人操作", "metal refiner Need human operation", "人力操作", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_automatic { get; set; }

        [Option("电解器功率，w", "Electrolyzer power，w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float Electrolyzer_Electricity { get; set; }

        [Option("电解器排出的氢气量，kg", "The amount of hydrogen gas discharged from the electrolyzer", "排气配置",Format = "F2")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float HydrogenVolume { get; set; }

        [Option("电解器排出的氧气量，kg", "The amount of oxygen discharged by the electrolyzer", "排气配置", Format = "F2")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float OxygenVolume { get; set; }

        [Option("电解器不会发热", "Electrolyzer  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_SelfHeating { get; set; }

        [Option("电解器不会过热", "the electrolyzer overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_Overheat { get; set; }
        
        [Option("电解器不会淹没", "Will the electrolyzer flood", "建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_Submerge { get; set; }

        [Option("钻头前锥容纳的钻石量，kg", "The amount of diamonds held by the nose cone of the drill bit", "容量配置", Format="F0")]
        [Limit(1000, 2700.0)]
        [JsonProperty]
        public float NoseconeHarvest_Capacity { get; set; }

        [Option("人力发电机发电量，w", "ManualGeneratorr Generate Electricity，w", "发电配置", Format = "F0")]
        [Limit(400, 4000)]
        [JsonProperty]
        public float ManualGeneratorr_GenerateElectricity { get; set; }
        
        [Option("木料燃烧器发电量，w", "WoodGasGenerator Generate Electricity， w", "发电配置", Format = "F0")]
        [Limit(400, 4000)]
        [JsonProperty]
        public float WoodGasGenerator_GenerateElectricity { get; set; }

        [Option("木料燃烧器二氧化碳排放量，kg", "WoodGasGenerator Carbon Dioxide Volume，kg", "排气配置")]
        [Limit(0, 10000)]
        [JsonProperty]
        public float WoodGasGenerator_CarbonDioxideVolume { get; set; }

        [Option("木料燃烧器不会发热", "WoodGasGenerator Self Heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool WoodGasGenerator_SelfHeating { get; set; }

        [Option("煤炭发电机发电量，w", "Generator Generate Electricity， w", "发电配置", Format = "F0")]
        [Limit(600, 6000)]
        [JsonProperty]
        public float Generator_GenerateElectricity { get; set; }

        [Option("煤炭发电机二氧化碳排放量，kg", "Generator Carbon Dioxide Volume", "排气配置")]
        [Limit(0, 10000)]
        [JsonProperty]
        public float Generator_CarbonDioxideVolume { get; set; }

        [Option("煤炭发电机不会发热", "Generator Self Heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool Generator_SelfHeating { get; set; }

        [Option("氢气发电机发电量，w", "HydrogenGenerator Generate Electricity", "发电配置", Format = "F0")]
        [Limit(800, 8000)]
        [JsonProperty]
        public float HydrogenGenerator_GenerateElectricity { get; set; }

        [Option("氢气发电机不会发热", "HydrogenGenerator Self Heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool HydrogenGenerator_SelfHeating { get; set; }

        [Option("功率转变器不会发热", "PowerTransformer Self Heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool PowerTransformer_SelfHeating { get; set; }

        [Option("原油精炼器功率，w", "OilRefinery power，w", "功率配置", Format = "F0")]
        [Limit(1, 480)]
        [JsonProperty]
        public float OilRefinery_Electricity { get; set; }

        [Option("原油精炼器排出的天然气量，kg", "The amount of Methane gas discharged from the OilRefinery", "排气配置")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float MethaneVolume { get; set; }

        [Option("原油精炼器排出的石油量，kg", "The amount of Petroleum discharged by the OilRefinery", "排液配置")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float PetroleumVolume { get; set; }

        [Option("原油精炼器不会发热", "OilRefinery  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_SelfHeating { get; set; }

        [Option("原油精炼器不会过热", "the OilRefinery overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_Overheat { get; set; }

        [Option("原油精炼器不会淹没", "Will the OilRefinery flood", "建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_Submerge { get; set; }
        
        [Option("原油精炼器不需要复制人操作", "OilRefinery Need human operation", "人力操作", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_automatic { get; set; }


        [Option("水草", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 7200.0)]
        [JsonProperty]
        public float Lettuce_Growth_Time { get; set; }

        [Option("虫果", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 4800.0)]
        [JsonProperty]
        public float WormSuperFruit_Growth_Time { get; set; }

        [Option("米虱木", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 1800.0)]
        [JsonProperty]
        public float BasicPlantFood_Growth_Time { get; set; }

        [Option("毛刺花", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 3600.0)]
        [JsonProperty]
        public float PrickleFruit_Growth_Time { get; set; }

        [Option("夜幕菇", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 4500.0)]
        [JsonProperty]
        public float Mushroom_Growth_Time { get; set; }

        [Option("火椒藤", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 4800.0)]
        [JsonProperty]
        public float SpiceNut_Growth_Time { get; set; }

        [Option("释气草", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 2400.0)]
        [JsonProperty]
        public float GasGrassHarvested_Growth_Time { get; set; }

        [Option("乔木树", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 2700.0)]
        [JsonProperty]
        public float WoodLog_Growth_Time { get; set; }

        [Option("小吃芽", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 12600.0)]
        [JsonProperty]
        public float BeanPlantSeed_Growth_Time { get; set; }

        [Option("沙盐藤", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 3600.0)]
        [JsonProperty]
        public float Salt_Growth_Time { get; set; }

        [Option("仙水掌", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 6000.0)]
        [JsonProperty]
        public float Water_Growth_Time { get; set; }

        [Option("沼泽笼", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 3960.0)]
        [JsonProperty]
        public float SwampFruit_Growth_Time { get; set; }

        [Option("顶针芦苇", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 1200.0)]
        [JsonProperty]
        public float BasicFabric_Growth_Time { get; set; }

        [Option("冰霜小麦", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 10800.0)]
        [JsonProperty]
        public float ColdWheatSeed_Growth_Time { get; set; }

        [Option("芳香百合", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 7200.0)]
        [JsonProperty]
        public float SwampLilyFlower_Growth_Time { get; set; }

        [Option("贫瘠虫果", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 2400.0)]
        [JsonProperty]
        public float WormBasicFruit_Growth_Time { get; set; }

        [Option("土星动物蒱草", "", "植物生长时间/s", Format = "F0")]
        [Limit(10, 18000.0)]
        [JsonProperty]
        public float PlantMeat_Growth_Time { get; set; }



        [Option("水草", "", "植物收获数量")]
        [JsonProperty]
        public int Lettuce_Harvest_Quantity { get; set; }

        [Option("虫果", "", "植物收获数量")]
        [JsonProperty]
        public int WormSuperFruit_Harvest_Quantity { get; set; }

        [Option("米虱木", "", "植物收获数量")]
        [JsonProperty]
        public int BasicPlantFood_Harvest_Quantity { get; set; }

        [Option("毛刺花", "", "植物收获数量")]
        [JsonProperty]
        public int PrickleFruit_Harvest_Quantity { get; set; }

        [Option("夜幕菇", "", "植物收获数量")]
        [JsonProperty]
        public int Mushroom_Harvest_Quantity { get; set; }

        [Option("火椒藤", "", "植物收获数量")]
        [JsonProperty]
        public int SpiceNut_Harvest_Quantity { get; set; }

        [Option("释气草", "", "植物收获数量")]
        [JsonProperty]
        public int GasGrassHarvested_Harvest_Quantity { get; set; }

        [Option("乔木树", "", "植物收获数量")]
        [JsonProperty]
        public int WoodLog_Harvest_Quantity { get; set; }

        [Option("小吃芽", "", "植物收获数量")]
        [JsonProperty]
        public int BeanPlantSeed_Harvest_Quantity { get; set; }

        [Option("沙盐藤", "", "植物收获数量")]
        [JsonProperty]
        public int Salt_Harvest_Quantity { get; set; }

        [Option("仙水掌", "", "植物收获数量")]
        [JsonProperty]
        public int Water_Harvest_Quantity { get; set; }

        [Option("沼泽笼", "", "植物收获数量")]
        [JsonProperty]
        public int SwampFruit_Harvest_Quantity { get; set; }

        [Option("冰霜小麦", "", "植物收获数量")]
        [JsonProperty]
        public int ColdWheatSeed_Harvest_Quantity { get; set; }

        [Option("顶针芦苇", "", "植物收获数量")]
        [JsonProperty]
        public int BasicFabric_Harvest_Quantity { get; set; }

        [Option("芳香百合", "", "植物收获数量")]
        [JsonProperty]
        public int SwampLilyFlower_Harvest_Quantity { get; set; }

        [Option("贫瘠虫果", "", "植物收获数量")]
        [JsonProperty]
        public int WormBasicFruit_Harvest_Quantity { get; set; }

        [Option("土星动物蒱草", "", "植物收获数量")]
        [JsonProperty]
        public int PlantMeat_Harvest_Quantity { get; set; }

        [Option("液泵功率，w", "LiquidPump power， w", "功率配置", Format = "F0")]
        [Limit(1, 240)]
        [JsonProperty]
        public float LiquidPump_Electricity { get; set; }

        [Option("液泵不会发热", "LiquidPump  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidPump_SelfHeating { get; set; }

        [Option("液泵不会过热", "the LiquidPump overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidPump_Overheat { get; set; }

        [Option("液体过滤器功率，w", "LiquidFilter power， w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float LiquidFilter_Electricity { get; set; }

        [Option("液体过滤器不会发热", "LiquidFilter  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidFilter_SelfHeating { get; set; }

        [Option("液体过滤器不会过热", "the LiquidFilter overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidFilter_Overheat { get; set; }

        [Option("气体过滤器功率，w", "GasFilter power， w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float GasFilter_Electricity { get; set; }

        [Option("气体过滤器不会过热", "the GasFilter overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool GasFilter_Overheat { get; set; }

        [Option("自动清扫器功率，w", "SolidTransferArm power， w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float SolidTransferArm_Electricity { get; set; }

        [Option("自动清扫器不会发热", "SolidTransferArm  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidTransferArm_SelfHeating { get; set; }

        [Option("自动清扫器不会过热", "the SolidTransferArm overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidTransferArm_Overheat { get; set; }

        [Option("太阳能最大发电量，w", "storage box capacity，kg", "发电配置", Format = "F0")]
        [Limit(380, 3780.0)]
        [JsonProperty]
        public float Maximum_solar_power_generation { get; set; }

        [Option("太阳能每勒克斯的发电量", "1勒克斯*玩家设置的*14=太阳能板实际发电量", "发电配置", Format = "F5")]
        [Limit(0.00053, 0.01)]
        [JsonProperty]
        public float Power_per_lux_of_solar_energy { get; set; }
        
        [Option("运输轨道运输容量，kg", "", "运输配置", Format = "F0")]
        [Limit(20, 1000.0)]
        [JsonProperty]
        public float Transport_Track_Capacity { get; set; }

        [Option("运输存放器容量，kg", "", "容量配置", Format = "F0")]
        [Limit(100, 100000.0)]
        [JsonProperty]
        public float SolidConduitOutbox_Capacity { get; set; }

        [Option("运输装载器不会发热", "SolidConduitInbox  will self-heating", "建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidConduitInbox_SelfHeating { get; set; }

        [Option("运输装载器不会过热", "the SolidConduitInbox overheating", "建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidConduitInbox_Overheat { get; set; }

        [Option("运输装载器的容量，kg", "SolidConduitInbox capacity， kg", "容量配置", Format = "F0")]
        [Limit(1000, 100000)]
        [JsonProperty]
        public float SolidConduitInbox_Capacity { get; set; }

        [Option("运输装载器功率，w", "SolidConduitInbox power， w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float SolidConduitInbox_Electricity { get; set; }

        [Option("氧气扩散器功率，w", "MineralDeoxidizer power， w", "功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float MineralDeoxidizer_Electricity { get; set; }

        [Option("氧气扩散器不会被淹没", " Will the MineralDeoxidizer flood", "建筑淹没配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_Submerge { get; set; }

        [Option("氧气扩散器不会过热", "the MineralDeoxidizer overheating", "建筑过热配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_Overheat { get; set; }

        [Option("氧气扩散器不会发热", "MineralDeoxidizer  will self-heating", "建筑自热配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_SelfHeating { get; set; }

        [Option("氧气扩散器排出的氧气量，kg", "The amount of oxygen discharged by the MineralDeoxidizer", "排气配置",Format = "F1")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float MineralDeoxidizer_OxygenVolume { get; set; }

        [Option("电池舱容量", "", "容量配置", Format = "F1")]
        [Limit(100, 500000.0)]
        [JsonProperty]
        public float 电池舱容量 { get; set; }

        public ConfigurationItem()
        {
            this.电池舱 = false;
            this.电池舱容量 = 100f;
            this.Refrigerator_Capacity = 100f;//冰箱容量
            this.Refrigerator_Electricity = 120f;//冰箱功耗
            this.Refrigerator_Submerge = false;//冰箱淹没
            this.Refrigerator_Overheat = false;//冰箱过热
            this.StorageBox_Capacity = 2000f;//箱子容量
            this.StorageBox_Overheat = false;//箱子过热
            this.GasReservoir_Capacity = 150f;//气库容量
            this.GasReservoir_foundation = false;//气库必须建造在地面上
            this.GasReservoir_Overheat = false;//气库过热
            this.LiquidReservoir_Capacity = 5000f;//液库容量
            this.LiquidReservoir_foundation = false;//液库必须建造在地面上
            this.LiquidReservoir_Overheat = false;//液库过热
            this.ElectricWire_Thinline = 1f;//电线1kw
            this.ElectricWire_wire = 2f;//导线2kw
            this.ElectricWire_Thickline = 20f;//高负荷电线20kw
            this.ElectricWire_HighVoltageline = 50f;//高负荷导线50kw
            this.HightDiggingRatio_Magnification = 0.5f;//默认是0.5，挖掘减半
            this.Mop_Max = false;//擦水限制质量
            this.MetalRefinery_Capacity = 800f;//金属精炼器容量
            this.MetalRefinery_Electricity = 1200f;//金属精炼器耗电量
            this.MetalRefinery_Heating = false;//金属精炼器加热冷却剂
            this.MetalRefinery_SelfHeating = false;//金属精炼器自热
            this.MetalRefinery_Submerge = false;//金属精炼器淹没
            this.MetalRefinery_Overheat = false;//金属精炼器过热
            this.MetalRefinery_automatic = false;//金属精炼器要复制人操作
            this.Electrolyzer_Electricity = 120f;//电解器功率
            this.HydrogenVolume = 0.11199999f;//电解器排氢气
            this.OxygenVolume = 0.888f;//电解器排氧气
            this.Electrolyzer_SelfHeating = false;//电解器自热
            this.Electrolyzer_Overheat = false;//电解器过热
            this.Electrolyzer_Submerge = false;//电解器淹没
            this.NoseconeHarvest_Capacity = 1000f;//钻头前锥的容量
            this.ManualGeneratorr_GenerateElectricity = 400f;//人力发电机发电
            this.WoodGasGenerator_GenerateElectricity = 300f;//木料发电
            this.WoodGasGenerator_CarbonDioxideVolume = 0.17f;//木料二氧化碳排放
            this.WoodGasGenerator_SelfHeating = false;//木料自热
            this.Generator_GenerateElectricity = 600f;//煤炭发电机
            this.Generator_CarbonDioxideVolume = 0.02f;//煤炭发电机二氧化碳排放
            this.Generator_SelfHeating = false;//煤炭发电机自热
            this.HydrogenGenerator_GenerateElectricity = 800f;//氢气发电机
            this.HydrogenGenerator_SelfHeating = false;//氢气发电机发热
            this.PowerTransformer_SelfHeating = false;//变压器发热
            this.OilRefinery_Electricity = 480f;//原油精炼器功率
            this.MethaneVolume = 0.09f;//原油精炼器排出的天然气量
            this.PetroleumVolume = 5f;//原油精炼器排出的石油量
            this.OilRefinery_SelfHeating = false;//原油精炼器不会发热
            this.OilRefinery_Overheat = false;//原油精炼器不会过热
            this.OilRefinery_Submerge = false;//原油精炼器不会淹没
            this.OilRefinery_automatic = false;//原油精炼器需要小人操作
            this.LiquidPump_Electricity = 240f;//液泵功率
            this.LiquidPump_SelfHeating = false;//液泵自热
            this.LiquidPump_Overheat = false;//液泵过热
            this.LiquidFilter_Electricity = 120f;//液体过滤器功率
            this.LiquidFilter_Overheat = false;//液体过滤器不会过热
            this.LiquidFilter_SelfHeating = false;//液体过滤器不会发热
            this.GasFilter_Electricity = 120f;//气体过滤器功率
            this.GasFilter_Overheat = false;//气体过滤器不会过热
            this.SolidTransferArm_Electricity = 120f;//自动清扫器功率
            this.SolidTransferArm_Overheat = false;//自动清扫器不会过热
            this.SolidTransferArm_SelfHeating = false;//自动清扫器不会发热
            this.Maximum_solar_power_generation = 380f;//太阳能板最大发电量
            this.Power_per_lux_of_solar_energy = 0.00053f;//每勒克斯的电力
            this.Transport_Track_Capacity = 20f;//运输轨道容量
            this.SolidConduitOutbox_Capacity = 100f;//运输存放器容量
            this.SolidConduitInbox_SelfHeating = false;//运输运输装载器自热
            this.SolidConduitInbox_Overheat = false;//运输装载器过热
            this.SolidConduitInbox_Capacity = 1000f;//运输装载器容量
            this.SolidConduitInbox_Electricity = 120f;//运输装载器功率
            this.MineralDeoxidizer_Electricity = 120f;//氧气扩散器功率
            this.MineralDeoxidizer_Submerge = false;//氧气扩散器不会被淹没
            this.MineralDeoxidizer_Overheat = false;//氧气扩散器不会过热
            this.MineralDeoxidizer_SelfHeating = false;//氧气扩散器不会发热
            this.MineralDeoxidizer_OxygenVolume = 0.5f;//氧气扩散器排出的氧气量


            //
            //
            //
            this.BasicPlantFood_Growth_Time = 1800f;
            this.PrickleFruit_Growth_Time = 3600f;
            this.Mushroom_Growth_Time = 4500f;
            this.ColdWheatSeed_Growth_Time = 10800f;
            this.SpiceNut_Growth_Time = 4800f;
            this.BasicFabric_Growth_Time = 1200f;
            this.SwampLilyFlower_Growth_Time = 7200f;
            this.GasGrassHarvested_Growth_Time = 2400f;
            this.WoodLog_Growth_Time = 2700f;
            this.Lettuce_Growth_Time = 7200f;
            this.BeanPlantSeed_Growth_Time = 12600f;
            this.Salt_Growth_Time = 3600f;
            this.SwampFruit_Growth_Time = 3960f;
            this.PlantMeat_Growth_Time = 18000f;
            this.WormBasicFruit_Growth_Time = 2400f;
            this.WormSuperFruit_Growth_Time = 4800f;
            this.Water_Growth_Time = 6000f;
            //
            this.BasicPlantFood_Harvest_Quantity = 1;
            this.PrickleFruit_Harvest_Quantity = 1;
            this.Mushroom_Harvest_Quantity = 1;
            this.ColdWheatSeed_Harvest_Quantity = 18;
            this.SpiceNut_Harvest_Quantity = 4;
            this.BasicFabric_Harvest_Quantity = 1;
            this.SwampLilyFlower_Harvest_Quantity = 2;
            this.GasGrassHarvested_Harvest_Quantity = 1;
            this.WoodLog_Harvest_Quantity = 300;
            this.Lettuce_Harvest_Quantity = 12;
            this.BeanPlantSeed_Harvest_Quantity = 12;
            this.Salt_Harvest_Quantity = 65;
            this.SwampFruit_Harvest_Quantity = 1;
            this.PlantMeat_Harvest_Quantity = 10;
            this.WormBasicFruit_Harvest_Quantity = 1;
            this.WormSuperFruit_Harvest_Quantity = 8;
            this.Water_Harvest_Quantity = 350;
            
            //
            //
        }
    }
}
