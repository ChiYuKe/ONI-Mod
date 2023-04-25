using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox
{
    public static class STRINGS2
    {
        public static LocString 电力配置 = "电力配置";
        public static LocString 功率配置 = "功率配置";
        public static LocString 容量配置 = "容量配置";
        public static LocString 建筑淹没配置 = "建筑淹没配置";
        public static LocString 建筑过热配置 = "建筑过热配置";
        public static LocString 排气配置 = "排气配置";
        public static LocString 排液配置 = "排液配置";
        public static LocString 建筑自热配置 = "建筑自热配置";
        public static LocString 人力操作 = "人力操作";
        public static LocString 植物生长时间 = "植物生长时间";
        public static LocString 植物收获数量 = "植物收获数量";
        public static LocString 运输配置 = "运输配置";

    }
    public static class 建筑2
    {
        public static class 冰箱
        {
            public static LocString 容量 = "冰箱容量 /kg";
            public static LocString 功率 = "冰箱功率";
            public static LocString 过热 = "冰箱不会过热";
            public static LocString 淹没 = "冰箱不会被淹没";
        }
        public static class 储物箱
        {
            public static LocString 容量 = "储物箱容量 /kg";
            //public static LocString 过热 = "储物箱不会过热";
        }
        public static class 气库
        {
            public static LocString 容量 = "气库容量 /kg";
            public static LocString 地基 = "气库不需要地面建造";
            public static LocString 过热 = "气库不会过热";
        }
        public static class 液库
        {
            public static LocString 容量 = "液库容量 /kg";
            public static LocString 地基 = "液库不需要地面建造";
            public static LocString 过热 = "液库不会过热";
        }
        public static class 线路
        {
            public static LocString 电线 = "电线负载，/kw";
            public static LocString 导线 = "导线负载, /kw";
            public static LocString 高负荷电线 = "高负荷电线负载, /kw";
            public static LocString 高负荷导线 = "高负荷导线负载, /kw";
        }
        public static class 金属精炼器
        {
            public static LocString 容量 = "金属精炼器装入的冷却液容量 /kg";
            public static LocString 功率 = "金属精炼器消耗的电力";
            public static LocString 加热冷却剂 = "金属精炼器不加热冷却剂";
            public static LocString 发热 = "金属精炼器不会发热";
            public static LocString 淹没 = "金属精炼器不会被淹没";
            public static LocString 过热 = "金属精炼器不会过热";
            public static LocString 操作 = "金属精炼器不需要复制人去操作";
        }
        public static class 电解器
        {
            public static LocString 功率 = "电解器消耗的电力";
            public static LocString 排出的氢气量 = "电解器排出的氢气量， /kg";
            public static LocString 排出的氧气量 = "电解器排出的氧气量, /kg";
            public static LocString 发热 = "电解器不会发热";
            public static LocString 过热 = "电解器不会过热";
            public static LocString 淹没 = "电解器不会被淹没";
        }
        public static class 氧气扩散器
        {
            public static LocString 功率 = "氧气扩散器消耗的电力";
            public static LocString 排出的氧气量 = "氧气扩散器排出的氧气量， /kg";
            public static LocString 发热 = "氧气扩散器不会发热";
            public static LocString 过热 = "氧气扩散器不会过热";
            public static LocString 淹没 = "氧气扩散器不会被淹没";
        }
        public static class 火箭
        {
            public static LocString 钻头前锥钻石容量 = "钻头前锥可装入的钻石量";
        }
        public static class 人力发电机
        {
            public static LocString 发电量 = "人力发电机发电量";
        }
        public static class 木料燃烧器
        {
            public static LocString 发电量 = "木料燃烧器发电量";
            public static LocString 发热 = "木料燃烧器不会发热";
            public static LocString 二氧化碳排放量 = "木料燃烧器排出的二氧化碳量";
        }
        public static class 煤炭发电机
        {
            public static LocString 发电量 = "煤炭发电机发电量";
            public static LocString 发热 = "煤炭发电机不会发热";
            public static LocString 二氧化碳排放量 = "煤炭发电机二氧化碳排放量";
        }
        public static class 氢气发电机
        {
            public static LocString 发电量 = "氢气发电机发电量";
            public static LocString 发热 = "氢气发电机不会发热";
        }
        public static class 太阳能
        {
            public static LocString 发电量 = "太阳能最大发电容量";
            public static LocString 勒克斯 = "每勒克斯的发电量";
        }
        public static class 功率转变器
        {
            public static LocString 发热 = "功率转变器不会发热";
        }
        public static class 原油精炼器
        {
            public static LocString 功率 = "原油精炼器消耗的电力";
            public static LocString 天然气量 = "原油精炼器排出的天然气量，/kg";
            public static LocString 石油量 = "原油精炼器排出的石油量，/kg";
            public static LocString 发热 = "原油精炼器不会发热";
            public static LocString 淹没 = "原油精炼器不会淹没";
            public static LocString 过热 = "原油精炼器不会过热";
            public static LocString 操作 = "原油精炼器不需要复制人去操作";
        }
        public static class 液泵
        {
            public static LocString 功率 = "液泵消耗的电力";
            public static LocString 发热 = "液泵不会发热";
            public static LocString 过热 = "液泵不会过热";
        }
        public static class 液体过滤器
        {
            public static LocString 功率 = "液体过滤器消耗的电力";
            public static LocString 发热 = "液体过滤器不会发热";
            public static LocString 过热 = "液体过滤器不会过热";
        }
        public static class 气体过滤器
        {
            public static LocString 功率 = "气体过滤器消耗的电力";
            public static LocString 过热 = "气体过滤器不会过热";
        }
        public static class 自动清扫器
        {
            public static LocString 功率 = "自动清扫器消耗的电力";
            public static LocString 发热 = "自动清扫器不会发热";
            public static LocString 过热 = "自动清扫器不会过热";
        }
        public static class 运输轨道
        {
            public static LocString 容量 = "运输轨道能运送的最大重量 /kg";
        }
        public static class 运输存放器
        {
            public static LocString 容量 = "运输存放器容量 /kg";
        }
        public static class 运输装载器
        {
            public static LocString 容量 = "运输装载器 /kg";
            public static LocString 发热 = "运输装载器不会发热";
            public static LocString 过热 = "运输装载器不会过热";
            public static LocString 功率 = "运输装载器消耗的电力";
        }
        public static class 电池舱
        {
            public static LocString 容量 = "电池舱容量";
            public static LocString 漏电 = "电池舱不会漏电";
        }
    }
    public static class 其它2
    {
        public static class 植物
        {
            public static LocString 水草 = "水草";
            public static LocString 虫果 = "虫果";
            public static LocString 米虱木 = "米虱木";
            public static LocString 毛刺花 = "毛刺花";
            public static LocString 夜幕菇 = "夜幕菇";
            public static LocString 火椒藤 = "火椒藤";
            public static LocString 释气草 = "释气草";
            public static LocString 乔木树 = "乔木树";
            public static LocString 小吃芽 = "小吃芽";
            public static LocString 沙盐藤 = "沙盐藤";
            public static LocString 仙水掌 = "仙水掌";
            public static LocString 沼浆笼 = "沼浆笼";
            public static LocString 顶针芦苇 = "顶针芦苇";
            public static LocString 冰霜小麦 = "冰霜小麦";
            public static LocString 芳香百合 = "芳香百合";
            public static LocString 贫瘠虫果 = "贫瘠虫果";
            public static LocString 土星动物捕草 = "土星动物捕草";
        }
        public static class 超级气压服
        {
            public static LocString 描述 = "超级气压服";
        }
        public static class 挖掘掉落
        {
            public static LocString 描述 = "挖掘掉落的倍数";
        }
        public static class 擦水
        {
            public static LocString 描述 = "擦水无视液体质量";
        }
    }
}
