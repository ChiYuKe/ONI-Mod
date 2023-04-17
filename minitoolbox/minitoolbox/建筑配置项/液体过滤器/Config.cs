using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.液体过滤器
{
    public class 液体过滤器
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_Electricity;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_Overheat ? false : true;
        public static bool 发热 = SingletonOptions<ConfigurationItem>.Instance.LiquidFilter_SelfHeating ? false : true;


    }
}
