using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.冰箱
{
    public class 冰箱
    {
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Capacity;
        public static float 耗电 = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Electricity;
        public static bool 淹没 = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Submerge ? false : true;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.Refrigerator_Overheat ? false : true;
    }
}
