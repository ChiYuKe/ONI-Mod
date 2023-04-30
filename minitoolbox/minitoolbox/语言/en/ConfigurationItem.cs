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
        [Option("minitoolbox.其他.睡觉.描述", "", null)]
        [JsonProperty]
        public bool NoWantSleepPatch { get; set; }

        [Option("minitoolbox.建筑.电池舱.漏电", "", null, Format = "F0")]
        [JsonProperty]
        public bool 电池舱 { get; set; }

        [Option("minitoolbox.其它.超级气压服.描述", "气压服各项属性显著提升！", null, Format = "F0")]
        [JsonProperty]
        public bool super_atmosuit { get; set; }

        [Option("minitoolbox.其它.挖掘掉落.描述", "", null, Format = "F1")]
        //区间是0.5到5倍，0.5是缺氧默认的
        [Limit(0.5, 5)]
        [JsonProperty]
        public float HightDiggingRatio_Magnification { get; set; }

        [Option("minitoolbox.其它.擦水.描述", "", null, Format = "F0")]
        [JsonProperty]
        public bool Mop_Max { get; set; }
        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.冰箱.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(100.0, 1000000.0)]
        [JsonProperty]
        public float Refrigerator_Capacity { get; set; }

        [Option("minitoolbox.建筑.冰箱.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1,120)]
        [JsonProperty]
        public float Refrigerator_Electricity { get; set; }

        [Option("minitoolbox.建筑.冰箱.淹没", "", "minitoolbox.STRINGS.建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool Refrigerator_Submerge { get; set; }

        [Option("minitoolbox.建筑.冰箱.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool Refrigerator_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.储物箱.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(2000.0, 10000000.0)]
        [JsonProperty]
        public float StorageBox_Capacity { get; set; }

        //[Option("minitoolbox.建筑.储物箱.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        //[JsonProperty]
        //public bool StorageBox_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.气库.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(150, 100000.0)]
        [JsonProperty]
        public float GasReservoir_Capacity { get; set; }

        [Option("minitoolbox.建筑.气库.地基", "", null, Format = "F0")]
        [JsonProperty]
        public bool GasReservoir_foundation { get; set; }

        [Option("minitoolbox.建筑.气库.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool GasReservoir_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.液库.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(5000, 100000.0)]
        [JsonProperty]
        public float LiquidReservoir_Capacity { get; set; }

        [Option("minitoolbox.建筑.液库.地基", "", null, Format = "F0")]
        [JsonProperty]
        public bool LiquidReservoir_foundation { get; set; }

        [Option("minitoolbox.建筑.液库.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidReservoir_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.线路.电线", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(1, 1000.0)]
        [JsonProperty]
        public float ElectricWire_Thinline { get; set; }

        [Option("minitoolbox.建筑.线路.导线", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(2, 1000.0)]
        [JsonProperty]
        public float ElectricWire_wire { get; set; }

        [Option("minitoolbox.建筑.线路.高负荷电线", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(20, 1000.0)]
        [JsonProperty]
        public float ElectricWire_Thickline { get; set; }

        [Option("minitoolbox.建筑.线路.高负荷导线", " ", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(50, 1000.0)]
        [JsonProperty]
        public float ElectricWire_HighVoltageline { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.金属精炼器.容量", " ", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(800, 4000)]
        [JsonProperty]
        public float MetalRefinery_Capacity { get; set; }
        
        [Option("minitoolbox.建筑.金属精炼器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 1200)]
        [JsonProperty]
        public float MetalRefinery_Electricity { get; set; }

        [Option("minitoolbox.建筑.金属精炼器.加热冷却剂", "", null, Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Heating { get; set; }

        [Option("minitoolbox.建筑.金属精炼器.发热", "", "minitoolbox.STRINGS.建筑自热配置")]
        [JsonProperty]
        public bool MetalRefinery_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.金属精炼器.淹没", "", "minitoolbox.STRINGS.建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Submerge { get; set; }

        [Option("minitoolbox.建筑.金属精炼器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_Overheat { get; set; }
       
        [Option("minitoolbox.建筑.金属精炼器.操作", "", "minitoolbox.STRINGS.人力操作", Format = "F0")]
        [JsonProperty]
        public bool MetalRefinery_automatic { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.电解器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float Electrolyzer_Electricity { get; set; }

        [Option("minitoolbox.建筑.电解器.排出的氢气量", "", "minitoolbox.STRINGS.排气配置",Format = "F2")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float HydrogenVolume { get; set; }

        [Option("minitoolbox.建筑.电解器.排出的氧气量", "", "minitoolbox.STRINGS.排气配置", Format = "F2")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float OxygenVolume { get; set; }

        [Option("minitoolbox.建筑.电解器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.电解器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_Overheat { get; set; }
        
        [Option("minitoolbox.建筑.电解器.淹没", "", "minitoolbox.STRINGS.建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool Electrolyzer_Submerge { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.火箭.钻头前锥钻石容量", "", "minitoolbox.STRINGS.容量配置", Format="F0")]
        [Limit(1000, 2700.0)]
        [JsonProperty]
        public float NoseconeHarvest_Capacity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.人力发电机.发电量", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(400, 4000)]
        [JsonProperty]
        public float ManualGeneratorr_GenerateElectricity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.木料燃烧器.发电量", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(400, 4000)]
        [JsonProperty]
        public float WoodGasGenerator_GenerateElectricity { get; set; }

        [Option("minitoolbox.建筑.木料燃烧器.二氧化碳排放量", "", "minitoolbox.STRINGS.排气配置")]
        [Limit(0, 10000)]
        [JsonProperty]
        public float WoodGasGenerator_CarbonDioxideVolume { get; set; }

        [Option("minitoolbox.建筑.木料燃烧器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool WoodGasGenerator_SelfHeating { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.煤炭发电机.发电量", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(600, 6000)]
        [JsonProperty]
        public float Generator_GenerateElectricity { get; set; }

        [Option("minitoolbox.建筑.煤炭发电机.二氧化碳排放量", "", "minitoolbox.STRINGS.排气配置")]
        [Limit(0, 10000)]
        [JsonProperty]
        public float Generator_CarbonDioxideVolume { get; set; }

        [Option("minitoolbox.建筑.煤炭发电机.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool Generator_SelfHeating { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.氢气发电机.发电量", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(800, 8000)]
        [JsonProperty]
        public float HydrogenGenerator_GenerateElectricity { get; set; }

        [Option("minitoolbox.建筑.氢气发电机.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool HydrogenGenerator_SelfHeating { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.太阳能.发电量", "", "minitoolbox.STRINGS.电力配置", Format = "F0")]
        [Limit(380, 3780.0)]
        [JsonProperty]
        public float Maximum_solar_power_generation { get; set; }

        [Option("minitoolbox.建筑.太阳能.勒克斯", "", "minitoolbox.STRINGS.电力配置", Format = "F5")]
        [Limit(0.00053, 0.01)]
        [JsonProperty]
        public float Power_per_lux_of_solar_energy { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.功率转变器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool PowerTransformer_SelfHeating { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.原油精炼器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 480)]
        [JsonProperty]
        public float OilRefinery_Electricity { get; set; }

        [Option("minitoolbox.建筑.原油精炼器.天然气量", "", "minitoolbox.STRINGS.排气配置")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float MethaneVolume { get; set; }

        [Option("minitoolbox.建筑.原油精炼器.石油量", "", "minitoolbox.STRINGS.排液配置")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float PetroleumVolume { get; set; }

        [Option("minitoolbox.建筑.原油精炼器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.原油精炼器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_Overheat { get; set; }

        [Option("minitoolbox.建筑.原油精炼器.淹没", "", "minitoolbox.STRINGS.建筑淹没配置", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_Submerge { get; set; }
        
        [Option("minitoolbox.建筑.原油精炼器.操作", "", "minitoolbox.STRINGS.人力操作", Format = "F0")]
        [JsonProperty]
        public bool OilRefinery_automatic { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.其它.植物.水草", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 7200.0)]
        [JsonProperty]
        public float Lettuce_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.虫果", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 4800.0)]
        [JsonProperty]
        public float WormSuperFruit_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.米虱木", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 1800.0)]
        [JsonProperty]
        public float BasicPlantFood_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.毛刺花", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 3600.0)]
        [JsonProperty]
        public float PrickleFruit_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.夜幕菇", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 4500.0)]
        [JsonProperty]
        public float Mushroom_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.火椒藤", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 4800.0)]
        [JsonProperty]
        public float SpiceNut_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.释气草", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 2400.0)]
        [JsonProperty]
        public float GasGrassHarvested_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.乔木树", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 2700.0)]
        [JsonProperty]
        public float WoodLog_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.小吃芽", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 12600.0)]
        [JsonProperty]
        public float BeanPlantSeed_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.沙盐藤", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 3600.0)]
        [JsonProperty]
        public float Salt_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.仙水掌", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 6000.0)]
        [JsonProperty]
        public float Water_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.沼浆笼", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 3960.0)]
        [JsonProperty]
        public float SwampFruit_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.顶针芦苇", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 1200.0)]
        [JsonProperty]
        public float BasicFabric_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.冰霜小麦", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 10800.0)]
        [JsonProperty]
        public float ColdWheatSeed_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.芳香百合", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 7200.0)]
        [JsonProperty]
        public float SwampLilyFlower_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.贫瘠虫果", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 2400.0)]
        [JsonProperty]
        public float WormBasicFruit_Growth_Time { get; set; }

        [Option("minitoolbox.其它.植物.土星动物捕草", "", "minitoolbox.STRINGS.植物生长时间", Format = "F0")]
        [Limit(10, 18000.0)]
        [JsonProperty]
        public float PlantMeat_Growth_Time { get; set; }


        [Option("minitoolbox.其它.植物.水草", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int Lettuce_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.虫果", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int WormSuperFruit_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.米虱木", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int BasicPlantFood_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.毛刺花", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int PrickleFruit_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.夜幕菇", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int Mushroom_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.火椒藤", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int SpiceNut_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.释气草", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int GasGrassHarvested_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.乔木树", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int WoodLog_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.小吃芽", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int BeanPlantSeed_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.沙盐藤", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int Salt_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.仙水掌", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int Water_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.沼浆笼", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int SwampFruit_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.冰霜小麦", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int ColdWheatSeed_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.顶针芦苇", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int BasicFabric_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.芳香百合", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int SwampLilyFlower_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.贫瘠虫果", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int WormBasicFruit_Harvest_Quantity { get; set; }

        [Option("minitoolbox.其它.植物.土星动物捕草", "", "minitoolbox.STRINGS.植物收获数量")]
        [JsonProperty]
        public int PlantMeat_Harvest_Quantity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.液泵.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 240)]
        [JsonProperty]
        public float LiquidPump_Electricity { get; set; }

        [Option("minitoolbox.建筑.液泵.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidPump_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.液泵.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidPump_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.液体过滤器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float LiquidFilter_Electricity { get; set; }

        [Option("minitoolbox.建筑.液体过滤器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidFilter_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.液体过滤器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool LiquidFilter_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.气体过滤器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float GasFilter_Electricity { get; set; }

        [Option("minitoolbox.建筑.气体过滤器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool GasFilter_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.自动清扫器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float SolidTransferArm_Electricity { get; set; }

        [Option("minitoolbox.建筑.自动清扫器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidTransferArm_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.自动清扫器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidTransferArm_Overheat { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.运输轨道.容量", "", "minitoolbox.STRINGS.运输配置", Format = "F0")]
        [Limit(20, 1000.0)]
        [JsonProperty]
        public float Transport_Track_Capacity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.运输存放器.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(100, 100000.0)]
        [JsonProperty]
        public float SolidConduitOutbox_Capacity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.运输装载器.发热", "", "minitoolbox.STRINGS.建筑自热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidConduitInbox_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.运输装载器.过热", "", "minitoolbox.STRINGS.建筑过热配置", Format = "F0")]
        [JsonProperty]
        public bool SolidConduitInbox_Overheat { get; set; }

        [Option("minitoolbox.建筑.运输装载器.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F0")]
        [Limit(1000, 100000)]
        [JsonProperty]
        public float SolidConduitInbox_Capacity { get; set; }

        [Option("minitoolbox.建筑.运输装载器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float SolidConduitInbox_Electricity { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.氧气扩散器.功率", "", "minitoolbox.STRINGS.功率配置", Format = "F0")]
        [Limit(1, 120)]
        [JsonProperty]
        public float MineralDeoxidizer_Electricity { get; set; }

        [Option("minitoolbox.建筑.氧气扩散器.淹没", "", "minitoolbox.STRINGS.建筑淹没配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_Submerge { get; set; }

        [Option("minitoolbox.建筑.氧气扩散器.过热", "", "minitoolbox.STRINGS.建筑过热配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_Overheat { get; set; }

        [Option("minitoolbox.建筑.氧气扩散器.发热", "", "minitoolbox.STRINGS.建筑自热配置")]
        [JsonProperty]
        public bool MineralDeoxidizer_SelfHeating { get; set; }

        [Option("minitoolbox.建筑.氧气扩散器.排出的氧气量", "", "minitoolbox.STRINGS.排气配置",Format = "F1")]
        [Limit(0, 5000.0)]
        [JsonProperty]
        public float MineralDeoxidizer_OxygenVolume { get; set; }

        //________________________________________________________________________________________
        [Option("minitoolbox.建筑.电池舱.容量", "", "minitoolbox.STRINGS.容量配置", Format = "F1")]
        [Limit(100, 500000.0)]
        [JsonProperty]
        public float 电池舱容量 { get; set; }

        public ConfigurationItem()
        {
            this.NoWantSleepPatch = false; 
            this.super_atmosuit = false;
            this.电池舱 = false;
            this.电池舱容量 = 100f;
            this.Refrigerator_Capacity = 100f;//冰箱容量
            this.Refrigerator_Electricity = 120f;//冰箱功耗
            this.Refrigerator_Submerge = false;//冰箱淹没
            this.Refrigerator_Overheat = false;//冰箱过热
            this.StorageBox_Capacity = 2000f;//箱子容量
            //this.StorageBox_Overheat = false;//箱子过热
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
