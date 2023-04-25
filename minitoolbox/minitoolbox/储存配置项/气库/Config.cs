using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.气库
{
    public class 气库
    {
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.GasReservoir_Overheat ? false : true;
        public static bool 地基 = SingletonOptions<ConfigurationItem>.Instance.GasReservoir_foundation ? false : true;
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.GasReservoir_Capacity;
        
    }
}
