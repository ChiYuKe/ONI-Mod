using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.装载器.运输装载器
{
    public class 运输装载器
    {
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Capacity;
        public static float 功率 = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Electricity;
        public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_Overheat ? false : true;
        public static bool 自热 = SingletonOptions<ConfigurationItem>.Instance.SolidConduitInbox_SelfHeating ? false : true;
    }
}
