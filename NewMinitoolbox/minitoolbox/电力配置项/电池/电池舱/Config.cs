using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.电池.电池舱
{
    public class 电池舱
    {
        public static float 电池容量 = SingletonOptions<ConfigurationItem>.Instance.电池舱容量 * 1000f;
        public static float 电源损耗 = SingletonOptions<ConfigurationItem>.Instance.电池舱 ? 0f : 0.6666667f;

    }
}
