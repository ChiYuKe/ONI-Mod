using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.发电机.氢气发电机
{
    public class 氢气发电机
    {
        public static bool 自热 = SingletonOptions<ConfigurationItem>.Instance.HydrogenGenerator_SelfHeating ? false : true;
        public static float 发电 = SingletonOptions<ConfigurationItem>.Instance.HydrogenGenerator_GenerateElectricity;
    }
}
