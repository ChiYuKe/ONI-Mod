using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.建筑配置项.气体过滤器
{
    public class 气体过滤器
    {
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.GasFilter_Electricity;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.GasFilter_Overheat ? false : true;
    }
}
