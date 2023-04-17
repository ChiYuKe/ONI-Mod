using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace penKo.二氧化碳泉
{
    public class 二氧化碳泉
    {
        public static int 产物 = int.Parse(Regex.Match(SingletonOptions<Settings>.Instance.二氧化碳泉_产物.ToString(), "\\d+").Value);

        public static float 温度 = SingletonOptions<Settings>.Instance.二氧化碳泉_温度 + 273.15f;
        public static float 最低平均产率 = SingletonOptions<Settings>.Instance.二氧化碳泉_最低平均产率;
        public static float 最高平均产率 = SingletonOptions<Settings>.Instance.二氧化碳泉_最高平均产率;
        public static float 最大压力 = SingletonOptions<Settings>.Instance.二氧化碳泉_最大压力;
        public static float 最低喷发周期 = SingletonOptions<Settings>.Instance.二氧化碳泉_喷发周期;
        public static float 最小活跃期 = SingletonOptions<Settings>.Instance.二氧化碳泉_活跃期;

        public static float 喷发期占比 = SingletonOptions<Settings>.Instance.二氧化碳泉_喷发期 ? 1f : 0.1f;
        public static float 喷发期占比MAX = SingletonOptions<Settings>.Instance.二氧化碳泉_喷发期 ? 1f : 0.9f;
        public static float 活跃期占比 = SingletonOptions<Settings>.Instance.二氧化碳泉_休眠期 ? 1f : 0.4f;
        public static float 活跃期占比MAX = SingletonOptions<Settings>.Instance.二氧化碳泉_休眠期 ? 1f : 0.8f;
    }

           
}
