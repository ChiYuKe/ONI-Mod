using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_food
{
    public class STRINGSS
    {
        public  class FOOD
        {
            public static readonly LocString BUNNYROLL_NAME = "兔子卷";
            public static readonly LocString MOONCAKE_NAME = "月饼";
            public static readonly LocString JELLY_NAME = "沼浆果冻";
            public static readonly LocString SHREDDEDPORKWITHCHILI_NAME = "辣椒肉丝";

            public static readonly LocString UB_NAME = "铀饼";
            public static readonly LocString UB_MS = "你也是小黑子吗.食不食" + UI.FormatAsLink(FOOD.UB_NAME, FOOD.UB_NAME) + "\n\n 复制人当中的小黑子越来越多，其他复制人看见小黑子就会问他食不食铀饼";
            public static readonly LocString UB_WK = "你也是小黑子吗.食不食" + UI.FormatAsLink(FOOD.UB_NAME, FOOD.UB_NAME) + "\n\n 复制人当中的小黑子越来越多，其他复制人看见小黑子就会问他食不食铀饼";
        }
        public  class DESC 
        {
            public static readonly LocString BUNNYROLL_DESC = "美味的" + UI.FormatAsLink(FOOD.BUNNYROLL_NAME, FOOD.BUNNYROLL_NAME) + "\n\n 告诉你一件可怕的事情，它是用活的兔子卷起来当做食品（这是一个玩笑，不是真的）";
            public static readonly LocString MOONCAKE_DESC = "美味的" + UI.FormatAsLink(FOOD.MOONCAKE_NAME, FOOD.MOONCAKE_NAME) + "\n\n 它的保质期很长，很适合当做一种太空食品.";
            public static readonly LocString JELLY_DESC = "美味的" + UI.FormatAsLink(FOOD.JELLY_NAME, FOOD.JELLY_NAME) + "\n\n 食品甜度很高、口感很柔软，吃下去后甚至让人感到迷茫或困惑.";
            public static readonly LocString SHREDDEDPORKWITHCHILI_DESC = "香喷喷的" + UI.FormatAsLink(FOOD.SHREDDEDPORKWITHCHILI_NAME, FOOD.SHREDDEDPORKWITHCHILI_NAME) + "\n\n 它太香了，又热又辣，让整个人充满了了狂暴的气息。";
        }
        public  class RECIPE
        {
            public static readonly LocString BUNNYROLL_RECIPE = "美味的" + UI.FormatAsLink(FOOD.BUNNYROLL_NAME, FOOD.BUNNYROLL_NAME) + "\n\n 告诉你一件可怕的事情，它是用活的兔子卷起来当做食品（这是一个玩笑，不是真的）.";
            public static readonly LocString MOONCAKE_RECIPE = "美味的" + UI.FormatAsLink(FOOD.MOONCAKE_NAME, FOOD.MOONCAKE_NAME) + "\n\n 它的保质期很长，很适合当做一种太空食品.";
            public static readonly LocString JELLY_RECIPE = "美味的" + UI.FormatAsLink(FOOD.JELLY_NAME, FOOD.JELLY_NAME) + "\n\n 食品甜度很高、口感很柔软，吃下去后甚至让人感到迷茫或困惑.";
            public static readonly LocString SHREDDEDPORKWITHCHILI_RECIPE = "香喷喷的" + UI.FormatAsLink(FOOD.SHREDDEDPORKWITHCHILI_NAME, FOOD.SHREDDEDPORKWITHCHILI_NAME) + "\n\n 它太香了，又热又辣，让整个人充满了了狂暴的气息。";
        }
    }
}
