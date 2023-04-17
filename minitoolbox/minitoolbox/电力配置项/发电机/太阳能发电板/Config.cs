using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.发电机.太阳能发电板
{
    public class 太阳能发电板
    {
        public static float 发电容量 = SingletonOptions<ConfigurationItem>.Instance.Maximum_solar_power_generation;
        public static float 太阳能 = SingletonOptions<ConfigurationItem>.Instance.Power_per_lux_of_solar_energy;
    }
}
