using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.金属精炼器
{
    public class 金属精炼器
    {
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Capacity;
        public static bool 加热 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Heating ? false : true;
        public static bool 操作 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_automatic ? false : true;
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Electricity;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_SelfHeating ? false : true;
        public static bool 淹没 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Submerge ? false : true;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.MetalRefinery_Overheat ? false : true;
    }
}
