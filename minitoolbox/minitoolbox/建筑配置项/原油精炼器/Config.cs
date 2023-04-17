using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.原油精炼器
{
    public class 原油精炼器
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Electricity;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_SelfHeating ? false : true;
        public static bool 淹没 = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Submerge ? false : true;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_Overheat ? false : true;
        public static float 天然气排放 = SingletonOptions<ConfigurationItem>.Instance.MethaneVolume;
        public static float 石油排放 = SingletonOptions<ConfigurationItem>.Instance.PetroleumVolume;
        public static bool 操作 = SingletonOptions<ConfigurationItem>.Instance.OilRefinery_automatic ? true : false;
    }
}
