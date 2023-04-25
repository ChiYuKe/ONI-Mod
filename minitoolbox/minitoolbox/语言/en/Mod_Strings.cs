using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox
{
    public static class STRINGS
    {
        public static LocString 电力配置 = "Power Configuration";
        public static LocString 功率配置 = "Power consumption";
        public static LocString 容量配置 = "does not generate heat";
        public static LocString 建筑淹没配置 = "Not overheat";
        public static LocString 建筑过热配置 = "Building Too Hot Configuration";
        public static LocString 排气配置 = "Exhaust Configuration";
        public static LocString 排液配置 = "Discharge Liquid Configuration";
        public static LocString 建筑自热配置 = "Building Self Heat Configuration";
        public static LocString 人力操作 = "duplicantOperated";
        public static LocString 植物生长时间 = "Plant growth time";
        public static LocString 植物收获数量 = "Number of plants harvested";
        public static LocString 运输配置 = "Transportation Configuration";

    }
    public static class 建筑
    {
        public static class 冰箱
        {
            public static LocString 容量 = "Refrigerator capacity /kg";
            public static LocString 功率 = "Refrigerator Power consumption";
            public static LocString 过热 = "Refrigerator Not overheat";
            public static LocString 淹没 = "Refrigerator Won't be submerged";
        }
        public static class 储物箱
        {
            public static LocString 容量 = "Storage Bin capacity /kg";
            //public static LocString 过热 = "Storage Bin Not overheat";
        }
        public static class 气库
        {
            public static LocString 容量 = "Gas Reservoir capacity /kg";
            public static LocString 地基 = "Gas Reservoir No need to build the ground";
            public static LocString 过热 = "Gas Reservoir Not overheat";
        }
        public static class 液库
        {
            public static LocString 容量 = "Liquid Reservoir capacity /kg";
            public static LocString 地基 = "Liquid Reservoir No need to build the ground";
            public static LocString 过热 = "Liquid Reservoir Not overheat";
        }
        public static class 线路
        {
            public static LocString 电线 = "Wire Overload limit，/kw";
            public static LocString 导线 = "Conductive Wire Overload limit, /kw";
            public static LocString 高负荷电线 = "Heavi-Watt Wire Overload limit, /kw";
            public static LocString 高负荷导线 = "Heavi-Watt Conductive Wire Overload limit, /kw";
        }
        public static class 金属精炼器
        {
            public static LocString 容量 = "Metal Refinery capacity /kg";
            public static LocString 功率 = "Metal Refinery Power consumption";
            public static LocString 加热冷却剂 = "Metal Refinery Heating input liquid";
            public static LocString 发热 = "Metal Refinery does not generate heat";
            public static LocString 淹没 = "Metal Refinery Won't be submerged";
            public static LocString 过热 = "Metal Refinery Not overheat";
            public static LocString 操作 = "Metal Refinery No operation required";
        }
        public static class 电解器
        {
            public static LocString 功率 = "Electrolyzer Power consumption";
            public static LocString 排出的氢气量 = "Electrolyzer Hydrogen emission， /kg";
            public static LocString 排出的氧气量 = "Electrolyzer amount of oxygen expelled, /kg";
            public static LocString 发热 = "Electrolyzer does not generate heat";
            public static LocString 过热 = "Electrolyzer Not overheat";
            public static LocString 淹没 = "Electrolyzer Won't be submerged";
        }
        public static class 氧气扩散器
        {
            public static LocString 功率 = "Oxygen Diffuser Power consumption";
            public static LocString 排出的氧气量 = "Oxygen Diffuser amount of oxygen expelled， /kg";
            public static LocString 发热 = "Oxygen Diffuser does not generate heat";
            public static LocString 过热 = "Oxygen Diffuser Not overheat";
            public static LocString 淹没 = "Oxygen Diffuser Won't be submerged";
        }
        public static class 火箭
        {
            public static LocString 钻头前锥钻石容量 = "Diamond capacity of drill head cone";
        }
        public static class 人力发电机
        {
            public static LocString 发电量 = "Manual Generator Generating power";
        }
        public static class 木料燃烧器
        {
            public static LocString 发电量 = "Wood Burner Generating power";
            public static LocString 发热 = "Wood Burner does not generate heat";
            public static LocString 二氧化碳排放量 = "Wood Burner Carbon dioxide emissions";
        }
        public static class 煤炭发电机
        {
            public static LocString 发电量 = "Coal Generator Generating power";
            public static LocString 发热 = "Coal Generator does not generate heat";
            public static LocString 二氧化碳排放量 = "Coal Generator Carbon dioxide emissions";
        }
        public static class 氢气发电机
        {
            public static LocString 发电量 = "Hydrogen Generator Generating power";
            public static LocString 发热 = "Hydrogen Generator does not generate heat";
        }
        public static class 太阳能
        {
            public static LocString 发电量 = "Solar Panel Generating power";
            public static LocString 勒克斯 = "Solar Panel Lux";
        }
        public static class 功率转变器
        {
            public static LocString 发热 = "Power Transformer does not generate heat";
        }
        public static class 原油精炼器
        {
            public static LocString 功率 = "Oil Refinery Power Configuration";
            public static LocString 天然气量 = "Oil Refinery Natural gas emission";
            public static LocString 石油量 = "Oil Refinery Oil emissions";
            public static LocString 发热 = "Oil Refinery does not generate heat";
            public static LocString 淹没 = "Oil Refinery Won't be submerged";
            public static LocString 过热 = "Oil Refinery Not overheat";
            public static LocString 操作 = "Oil Refinery No operation required";
        }
        public static class 液泵
        {
            public static LocString 功率 = "Liquid Pump Power consumption";
            public static LocString 发热 = "Liquid Pump does not generate heat";
            public static LocString 过热 = "Liquid Pump Not overheat";
        }
        public static class 液体过滤器
        {
            public static LocString 功率 = "Liquid Filter Power consumption";
            public static LocString 发热 = "Liquid Filter does not generate heat";
            public static LocString 过热 = "Liquid Filter Not overheat";
        }
        public static class 气体过滤器
        {
            public static LocString 功率 = "Gas Filter Power consumption";
            public static LocString 过热 = "Gas Filter Not overheat";
        }
        public static class 自动清扫器
        {
            public static LocString 功率 = "Auto-Sweeper Power consumption";
            public static LocString 发热 = "Auto-Sweeper does not generate heat";
            public static LocString 过热 = "Auto-Sweeper Not overheat";
        }
        public static class 运输轨道
        {
            public static LocString 容量 = "Conveyor Rail capacity /kg";
        }
        public static class 运输存放器
        {
            public static LocString 容量 = "SolidConduitOutbox capacity /kg";
        }
        public static class 运输装载器
        {
            public static LocString 容量 = "SolidConduitInbox capacity /kg";
            public static LocString 发热 = "SolidConduitInbox does not generate heat";
            public static LocString 过热 = "SolidConduitInbox Not overheat";
            public static LocString 功率 = "SolidConduitInbox Power consumption";
        }
        public static class 电池舱
        {
            public static LocString 容量 = "BatteryModule capacity";
            public static LocString 漏电 = "power leak";
        }
    }
    public static class 其它
    {
        public static class 植物
        {
            public static LocString 水草 = "Waterweed";
            public static LocString 虫果 = "Grubfruit";
            public static LocString 米虱木 = "Mealwood";
            public static LocString 毛刺花 = "Bristle Blossom";
            public static LocString 夜幕菇 = "Dusk Cap";
            public static LocString 火椒藤 = "Pincha Pepperplant";
            public static LocString 释气草 = "Gas Grass";
            public static LocString 乔木树 = "Arbor Tree";
            public static LocString 小吃芽 = "Nosh Sprout";
            public static LocString 沙盐藤 = "Dasha Saltvine";
            public static LocString 仙水掌 = "Hydrocactus";
            public static LocString 沼浆笼 = "Bog Bucket";
            public static LocString 顶针芦苇 = "Thimble Reed";
            public static LocString 冰霜小麦 = "Sleet Wheat";
            public static LocString 芳香百合 = "Balm Lily Flower";
            public static LocString 贫瘠虫果 = "Spindly Grubfruit Plant";
            public static LocString 土星动物捕草 = "Saturn Critter Trap";
        }
        public static class 超级气压服
        {
            public static LocString 描述 = "Super air pressure clothing";
        }
        public static class 挖掘掉落
        {
            public static LocString 描述 = "The multiple of fragments produced by mining";
        }
        public static class 擦水
        {
            public static LocString 描述 = "Wipe water ignores liquid mass";
        }
    }
}
