using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.装载器.运输存放器
{
    public class 运输存放器
    {
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.SolidConduitOutbox_Capacity;
    }
}
