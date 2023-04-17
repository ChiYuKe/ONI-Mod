using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.氧气扩散器
{
    public class 氧气扩散器
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Electricity;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_SelfHeating ? false : true;
        public static bool 淹没 = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Submerge ? false : true;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_Overheat ? false : true;
        public static float 排放 = SingletonOptions<ConfigurationItem>.Instance.MineralDeoxidizer_OxygenVolume;
    }
}
