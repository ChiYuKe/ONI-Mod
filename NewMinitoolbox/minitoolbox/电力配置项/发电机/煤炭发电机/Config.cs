﻿using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.电力配置项.发电机.煤炭发电机
{
    public class 煤炭发电机
    {
        public static bool 自热 = SingletonOptions<ConfigurationItem>.Instance.Generator_SelfHeating ? false : true;
        public static float 发电 = SingletonOptions<ConfigurationItem>.Instance.Generator_GenerateElectricity;
        public static float 碳排放 = SingletonOptions<ConfigurationItem>.Instance.Generator_CarbonDioxideVolume;
    }
}
