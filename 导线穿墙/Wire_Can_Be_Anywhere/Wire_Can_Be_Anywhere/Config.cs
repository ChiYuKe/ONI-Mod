using Newtonsoft.Json;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Can_Be_Anywhere
{
    [JsonObject(MemberSerialization.OptIn)]
    [ModInfo("https://steamcommunity.com/sharedfiles/filedetails/?id=2923332049", null, false)]
    [RestartRequired]
    public class Config : SingletonOptions<Config>
    {
        [Option("高负荷导线装饰度", "WireRefinedHighWattage_BaseDecor", null, Format = "F0")]
        [Limit(-20, 200)]
        [JsonProperty]
        public float WireRefinedHighWattage_BaseDecor { get; set; }

        [Option("高负荷导线装饰半径", "WireRefinedHighWattage_BaseDecorRadius", null, Format = "F0")]
        [Limit(4, 20)]
        [JsonProperty]
        public float WireRefinedHighWattage_BaseDecorRadius { get; set; }


        [Option("高负荷电线装饰度", "WireHighWattage_BaseDecor", null, Format = "F0")]
        [Limit(-20, 200)]
        [JsonProperty]
        public float WireHighWattage_BaseDecor { get; set; }

        [Option("高负荷电线装饰半径", "WireHighWattage_BaseDecorRadius", null, Format = "F0")]
        [Limit(6, 20)]
        [JsonProperty]
        public float WireHighWattage_BaseDecorRadius { get; set; }


        public Config()
        {
            this.WireRefinedHighWattage_BaseDecor = -20f;
            this.WireRefinedHighWattage_BaseDecorRadius = 4f;
            this.WireHighWattage_BaseDecor = -25f;
            this.WireHighWattage_BaseDecorRadius = 6f;
        }
    }
   
}
