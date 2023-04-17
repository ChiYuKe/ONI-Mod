using PeterHan.PLib.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penKo
{
    // Token: 0x02000003 RID: 3
    [JsonObject(MemberSerialization.OptIn)]
    //[ConfigFile("penKo.json", true, false)]
    [RestartRequired]
    public class Settings : SingletonOptions<Settings>
    {
        [Option("penKo.STRINGS.产生的物质", "", "penKo.类型.低温蒸汽喷孔配置")]
        [JsonProperty]
        public 泉选择Tag.Tag_El 低温蒸汽_产物 { get; set; }

        [Option("penKo.STRINGS.排出的物质温度", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(-120, 2700)]
        [JsonProperty]
        public float 低温蒸汽_温度 { get; set; }

        [Option("penKo.STRINGS.最低平均产率", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(1000, 1000000)]
        [JsonProperty]
        public float 低温蒸汽_最低平均产率 { get; set; }

        [Option("penKo.STRINGS.最高平均产率", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(2000, 1000000)]
        [JsonProperty]
        public float 低温蒸汽_最高平均产率 { get; set; }

        [Option("penKo.STRINGS.最大压力", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(5, 100000)]
        [JsonProperty]
        public float 低温蒸汽_最大压力 { get; set; }

        [Option("penKo.STRINGS.喷发周期", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(60, 1140)]
        [JsonProperty]
        public float 低温蒸汽_喷发周期 { get; set; }

        [Option("penKo.STRINGS.活跃期", "", "penKo.类型.低温蒸汽喷孔配置", Format = "F0")]
        [Limit(15000, 135000)]
        [JsonProperty]
        public float 低温蒸汽_活跃期 { get; set; }

        [Option("penKo.STRINGS.不会休眠", "", "penKo.类型.低温蒸汽喷孔配置")]

        [JsonProperty]
        public bool 低温蒸汽_休眠期 { get; set; }

        [Option("penKo.STRINGS.一直喷发", "", "penKo.类型.低温蒸汽喷孔配置")]
        [JsonProperty]
        public bool 低温蒸汽_喷发期 { get; set; }

        //---------------------------------------------------------------------------------------------------------
        [Option("penKo.STRINGS.产生的物质", "", "penKo.类型.小火山喷孔配置")]
        [JsonProperty]
        public 泉选择Tag.Tag_El 小火山_产物 { get; set; }

        [Option("penKo.STRINGS.排出的物质温度", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(-120, 3600)]
        [JsonProperty]
        public float 小火山_温度 { get; set; }

        [Option("penKo.STRINGS.最低平均产率", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(400, 1000000)]
        [JsonProperty]
        public float 小火山_最低平均产率 { get; set; }

        [Option("penKo.STRINGS.最高平均产率", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(800, 1000000)]
        [JsonProperty]
        public float 小火山_最高平均产率 { get; set; }

        [Option("penKo.STRINGS.最大压力", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(150, 100000)]
        [JsonProperty]
        public float 小火山_最大压力 { get; set; }

        [Option("penKo.STRINGS.喷发周期", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(6000, 12000)]
        [JsonProperty]
        public float 小火山_喷发周期 { get; set; }

        [Option("penKo.STRINGS.活跃期", "", "penKo.类型.小火山喷孔配置", Format = "F0")]
        [Limit(15000, 135000)]
        [JsonProperty]
        public float 小火山_活跃期 { get; set; }

        [Option("penKo.STRINGS.不会休眠", "", "penKo.类型.小火山喷孔配置")]

        [JsonProperty]
        public bool 小火山_休眠期 { get; set; }

        [Option("penKo.STRINGS.一直喷发", "", "penKo.类型.小火山喷孔配置")]
        [JsonProperty]
        public bool 小火山_喷发期 { get; set; }

        //---------------------------------------------------------------------------------------------------------
        [Option("penKo.STRINGS.产生的物质", "", "penKo.类型.二氧化碳泉配置")]
        [JsonProperty]
        public 泉选择Tag.Tag_El 二氧化碳泉_产物 { get; set; }

        [Option("penKo.STRINGS.排出的物质温度", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(-120, 2700)]
        [JsonProperty]
        public float 二氧化碳泉_温度 { get; set; }

        [Option("penKo.STRINGS.最低平均产率", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(100, 1000000)]
        [JsonProperty]
        public float 二氧化碳泉_最低平均产率 { get; set; }

        [Option("penKo.STRINGS.最高平均产率", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(200, 1000000)]
        [JsonProperty]
        public float 二氧化碳泉_最高平均产率 { get; set; }

        [Option("penKo.STRINGS.最大压力", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(50, 100000)]
        [JsonProperty]
        public float 二氧化碳泉_最大压力 { get; set; }

        [Option("penKo.STRINGS.喷发周期", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(60, 1140)]
        [JsonProperty]
        public float 二氧化碳泉_喷发周期 { get; set; }

        [Option("penKo.STRINGS.活跃期", "", "penKo.类型.二氧化碳泉配置", Format = "F0")]
        [Limit(15000, 135000)]
        [JsonProperty]
        public float 二氧化碳泉_活跃期 { get; set; }

        [Option("penKo.STRINGS.不会休眠", "", "penKo.类型.二氧化碳泉配置")]

        [JsonProperty]
        public bool 二氧化碳泉_休眠期 { get; set; }

        [Option("penKo.STRINGS.一直喷发", "", "penKo.类型.二氧化碳泉配置")]
        [JsonProperty]
        public bool 二氧化碳泉_喷发期 { get; set; }

        //---------------------------------------------------------------------------------------------------------
        [Option("penKo.STRINGS.产生的物质", "", "penKo.类型.二氧化碳喷孔配置")]
        [JsonProperty]
        public 泉选择Tag.Tag_El 二氧化碳喷孔_产物 { get; set; }

        [Option("penKo.STRINGS.排出的物质温度", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(-120, 2700)]
        [JsonProperty]
        public float 二氧化碳喷孔_温度 { get; set; }

        [Option("penKo.STRINGS.最低平均产率", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(70, 1000000)]
        [JsonProperty]
        public float 二氧化碳喷孔_最低平均产率 { get; set; }

        [Option("penKo.STRINGS.最高平均产率", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(140, 1000000)]
        [JsonProperty]
        public float 二氧化碳喷孔_最高平均产率 { get; set; }

        [Option("penKo.STRINGS.最大压力", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(5, 100000)]
        [JsonProperty]
        public float 二氧化碳喷孔_最大压力 { get; set; }

        [Option("penKo.STRINGS.喷发周期", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(60, 1140)]
        [JsonProperty]
        public float 二氧化碳喷孔_喷发周期 { get; set; }

        [Option("penKo.STRINGS.活跃期", "", "penKo.类型.二氧化碳喷孔配置", Format = "F0")]
        [Limit(15000, 135000)]
        [JsonProperty]
        public float 二氧化碳喷孔_活跃期 { get; set; }

        [Option("penKo.STRINGS.不会休眠", "", "penKo.类型.二氧化碳喷孔配置")]

        [JsonProperty]
        public bool 二氧化碳喷孔_休眠期 { get; set; }

        [Option("penKo.STRINGS.一直喷发", "", "penKo.类型.二氧化碳喷孔配置")]
        [JsonProperty]
        public bool 二氧化碳喷孔_喷发期 { get; set; }

        //---------------------------------------------------------------------------------------------------------
        [Option("penKo.STRINGS.产生的物质", "", "penKo.类型.氯气喷孔配置")]
        [JsonProperty]
        public 泉选择Tag.Tag_El 氯气喷孔_产物 { get; set; }

        [Option("penKo.STRINGS.排出的物质温度", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(-120, 2700)]
        [JsonProperty]
        public float 氯气喷孔_温度 { get; set; }

        [Option("penKo.STRINGS.最低平均产率", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(70, 1000000)]
        [JsonProperty]
        public float 氯气喷孔_最低平均产率 { get; set; }

        [Option("penKo.STRINGS.最高平均产率", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(140, 1000000)]
        [JsonProperty]
        public float 氯气喷孔_最高平均产率 { get; set; }

        [Option("penKo.STRINGS.最大压力", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(5, 100000)]
        [JsonProperty]
        public float 氯气喷孔_最大压力 { get; set; }

        [Option("penKo.STRINGS.喷发周期", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(60, 1140)]
        [JsonProperty]
        public float 氯气喷孔_喷发周期 { get; set; }

        [Option("penKo.STRINGS.活跃期", "", "penKo.类型.氯气喷孔配置", Format = "F0")]
        [Limit(15000, 135000)]
        [JsonProperty]
        public float 氯气喷孔_活跃期 { get; set; }

        [Option("penKo.STRINGS.不会休眠", "", "penKo.类型.氯气喷孔配置")]

        [JsonProperty]
        public bool 氯气喷孔_休眠期 { get; set; }

        [Option("penKo.STRINGS.一直喷发", "", "penKo.类型.氯气喷孔配置")]
        [JsonProperty]
        public bool 氯气喷孔_喷发期 { get; set; }

        public Settings()
        {
            this.低温蒸汽_产物 = 泉选择Tag.Tag_El.num3;
            this.低温蒸汽_温度 = 110f;
            this.低温蒸汽_最低平均产率 = 1000f;
            this.低温蒸汽_最高平均产率 = 2000f;
            this.低温蒸汽_最大压力 = 5f;
            this.低温蒸汽_喷发周期 = 60f;
            this.低温蒸汽_活跃期 = 15000f;
            this.低温蒸汽_休眠期 = false;
            this.低温蒸汽_喷发期 = false;

            this.小火山_产物 = 泉选择Tag.Tag_El.num28;
            this.小火山_温度 = 1726.85f;
            this.小火山_最低平均产率 = 800;
            this.小火山_最高平均产率 = 1600f;
            this.小火山_最大压力 = 150f;
            this.小火山_喷发周期 = 6000f;
            this.小火山_活跃期 = 15000f;
            this.小火山_休眠期 = false;
            this.小火山_喷发期 = false;

            this.二氧化碳泉_产物 = 泉选择Tag.Tag_El.num31;
            this.二氧化碳泉_温度 = -55.15f;
            this.二氧化碳泉_最低平均产率 = 100;
            this.二氧化碳泉_最高平均产率 = 200f;
            this.二氧化碳泉_最大压力 = 50f;
            this.二氧化碳泉_喷发周期 = 60f;
            this.二氧化碳泉_活跃期 = 15000f;
            this.二氧化碳泉_休眠期 = false;
            this.二氧化碳泉_喷发期 = false;

            this.二氧化碳喷孔_产物 = 泉选择Tag.Tag_El.num8;
            this.二氧化碳喷孔_温度 = 500f;
            this.二氧化碳喷孔_最低平均产率 = 70;
            this.二氧化碳喷孔_最高平均产率 = 140f;
            this.二氧化碳喷孔_最大压力 = 5f;
            this.二氧化碳喷孔_喷发周期 = 60f;
            this.二氧化碳喷孔_活跃期 = 15000f;
            this.二氧化碳喷孔_休眠期 = false;
            this.二氧化碳喷孔_喷发期 = false;

            this.氯气喷孔_产物 = 泉选择Tag.Tag_El.num0;
            this.氯气喷孔_温度 = 60f;
            this.氯气喷孔_最低平均产率 = 70;
            this.氯气喷孔_最高平均产率 = 140f;
            this.氯气喷孔_最大压力 = 5f;
            this.氯气喷孔_喷发周期 = 60f;
            this.氯气喷孔_活跃期 = 15000f;
            this.氯气喷孔_休眠期 = false;
            this.氯气喷孔_喷发期 = false;
        }
    }
    public class 泉选择Tag
    {
        public enum Tag_El
        {
            [Option("penKo.元素.氯_气", null, null)]
            num0,

            [Option("penKo.元素.氢气", null, null)]
            num1,

            [Option("penKo.元素.氧气", null, null)]
            num2,

            [Option("penKo.元素.蒸_汽", null, null)]
            num3,

            [Option("penKo.元素.天然气", null, null)]
            num4,

            [Option("penKo.元素.硫蒸气", null, null)]
            num5,

            [Option("penKo.元素.气态磷", null, null)]
            num6,

            [Option("penKo.元素.高硫天然气", null, null)]
            num7,

            [Option("penKo.元素.二氧化碳", null, null)]
            num8,

            [Option("penKo.元素.树脂", null, null)]
            num9,

            [Option("penKo.元素.金", null, null)]
            num10,

            [Option("penKo.元素.钨", null, null)]
            num11,

            [Option("penKo.元素.钴", null, null)]
            num12,

            [Option("penKo.元素.铁", null, null)]
            num13,

            [Option("penKo.元素.铅", null, null)]
            num14,

            [Option("penKo.元素.铜", null, null)]
            num15,

            [Option("penKo.元素.铝", null, null)]
            num16,

            [Option("penKo.元素.钢", null, null)]
            num17,

            [Option("penKo.元素.铌", null, null)]
            num18,

            [Option("penKo.元素.导热质", null, null)]
            num19,

            [Option("penKo.元素.浓缩铀", null, null)]
            num20,

            [Option("penKo.元素.泥土", null, null)]
            num21,

            [Option("penKo.元素.石灰", null, null)]
            num22,

            [Option("penKo.元素.熔融钨", null, null)]
            num23,

            [Option("penKo.元素.水", null, null)]
            num24,

            [Option("penKo.元素.污染水", null, null)]
            num25,

            [Option("penKo.元素.原油", null, null)]
            num26,

            [Option("penKo.元素.石油", null, null)]
            num27,

            [Option("penKo.元素.岩_浆", null, null)]
            num28,

            [Option("penKo.元素.熔融铌", null, null)]
            num29,

            [Option("penKo.元素.乙醇", null, null)]
            num30,

            [Option("penKo.元素.液态二氧化碳", null, null)]
            num31,

            [Option("penKo.元素.核废料", null, null)]
            num32,
        }
    }
}

