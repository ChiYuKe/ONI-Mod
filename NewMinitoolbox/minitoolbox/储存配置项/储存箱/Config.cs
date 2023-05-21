using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitoolbox.储存配置项.储存箱
{
    public class 储存箱
    {
        public static float 容量 = SingletonOptions<ConfigurationItem>.Instance.StorageBox_Capacity;
        //public static bool 过热 = SingletonOptions<ConfigurationItem>.Instance.StorageBox_Overheat ? false : true;
    }
}
