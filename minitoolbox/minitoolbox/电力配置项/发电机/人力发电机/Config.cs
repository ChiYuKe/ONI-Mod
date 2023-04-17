using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.发电机.人力发电机
{
    public class 人力发电机
    {
        public static float 发电 = SingletonOptions<ConfigurationItem>.Instance.ManualGeneratorr_GenerateElectricity;
    }
}