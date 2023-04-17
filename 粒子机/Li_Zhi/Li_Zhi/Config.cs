using Newtonsoft.Json;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Li_Zhi
{
    [JsonObject(MemberSerialization.OptIn)]
    [ModInfo("https://steamcommunity.com/sharedfiles/filedetails/?id=2923332049", null, false)]
    [RestartRequired]
    public class Config : SingletonOptions<Config>
    {
        [Option("采集率", "", null, Format = "F1")]
        [Limit(0.2, 1000)]
        [JsonProperty]
        public float WireRefinedHighWattage_BaseDecor { get; set; }

        public Config()
        {
            this.WireRefinedHighWattage_BaseDecor = 1000f;
        }


    }

}
