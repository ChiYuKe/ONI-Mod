using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.液泵
{
    public class 液泵
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_Electricity;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_Overheat ? false : true;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.LiquidPump_SelfHeating ? false : true;
    }
}
