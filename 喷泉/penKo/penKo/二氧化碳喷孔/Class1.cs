using Newtonsoft.Json;
using penKo;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace penKo.二氧化碳喷孔
{
    public class 二氧化碳喷孔
    {
        public static int 产物 = int.Parse(Regex.Match(SingletonOptions<Settings>.Instance.二氧化碳喷孔_产物.ToString(), "\\d+").Value);

        public static float 温度 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_温度 + 273.15f;
        public static float 最低平均产率 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_最低平均产率;
        public static float 最高平均产率 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_最高平均产率;
        public static float 最大压力 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_最大压力;
        public static float 最低喷发周期 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_喷发周期;
        public static float 最小活跃期 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_活跃期;

        public static float 喷发期占比 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_喷发期 ? 1f : 0.1f;
        public static float 喷发期占比MAX = SingletonOptions<Settings>.Instance.二氧化碳喷孔_喷发期 ? 1f : 0.9f;
        public static float 活跃期占比 = SingletonOptions<Settings>.Instance.二氧化碳喷孔_休眠期 ? 1f : 0.4f;
        public static float 活跃期占比MAX = SingletonOptions<Settings>.Instance.二氧化碳喷孔_休眠期 ? 1f : 0.8f;

    }
}
