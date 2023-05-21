using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.电解器
{
    public class 电解器
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_Electricity;
        public static bool 淹没 = SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_Submerge ? false : true;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_Overheat ? false : true;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.Electrolyzer_SelfHeating ? false : true;
        public static float 氧气排放量 = SingletonOptions<ConfigurationItem>.Instance.OxygenVolume;
        public static float 氢气排放量 = SingletonOptions<ConfigurationItem>.Instance.HydrogenVolume;
    }
}
