using Newtonsoft.Json;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static penKo.Settings;

namespace penKo.小火山
{
    public class 小火山
    {
        public static int 产物 = int.Parse(Regex.Match(SingletonOptions<Settings>.Instance.小火山_产物.ToString(), "\\d+").Value);

        public static float 温度 = SingletonOptions<Settings>.Instance.小火山_温度 + 273.15f;
        public static float 最低平均产率 = SingletonOptions<Settings>.Instance.小火山_最低平均产率;
        public static float 最高平均产率 = SingletonOptions<Settings>.Instance.小火山_最高平均产率;
        public static float 最大压力 = SingletonOptions<Settings>.Instance.小火山_最大压力;
        public static float 最低喷发周期 = SingletonOptions<Settings>.Instance.小火山_喷发周期;
        public static float 最小活跃期 = SingletonOptions<Settings>.Instance.小火山_活跃期; 
        public static float 喷发期占比 = SingletonOptions<Settings>.Instance.小火山_喷发期 ? 1f : 0.005f;
        public static float 喷发期占比MAX = SingletonOptions<Settings>.Instance.小火山_喷发期 ? 1f : 0.01f;
        public static float 活跃期占比 = SingletonOptions<Settings>.Instance.小火山_休眠期 ? 1f : 0.4f;
        public static float 活跃期占比MAX = SingletonOptions<Settings>.Instance.小火山_休眠期 ? 1f: 0.8f;

    }
            
}
