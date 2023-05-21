using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.电源线
{
    public class 电源线
    {
        public static float 电线 = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_Thinline * 1000f;
        public static float 导线 = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_wire * 1000f;
        public static float 高负荷电线 = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_Thickline * 1000f;
        public static float 高负荷导线 = SingletonOptions<ConfigurationItem>.Instance.ElectricWire_HighVoltageline * 1000f;


    }
}
