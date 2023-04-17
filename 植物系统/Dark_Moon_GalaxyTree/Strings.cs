using System;
using System.Collections.Generic;
using STRINGS;
using System.Text;
using System.Threading.Tasks;
using PeterHan.PLib.Actions;

namespace Dark_Moon_GalaxyTree
{
    public static class Strings
    {
        public static LocString NAME = "Oxyfruit";
        public static LocString NAME1 = "Star River Oxyfruit Rice";
        public static LocString NAME3 = "Carbonaceous Stake";

        public static LocString DESCRIPTION = "It is said that Dark Moon Star River he personally loves to eat and has a higher skill to cook";
        public static LocString DESCRIPTION1 = "Cooking" + UI.FormatAsLink(Strings.NAME, Dark_Moon_GalaxyFruitConfig.Id) + ".\n\nLong time subject to the dark moon star river cooking skills will be oxygen oxygen fruit into a delicious fruit rice\n\n\r\n(Take a bite, mmm ...... Mom's taste!!!)";
        public static LocString RECIPE = "The cooking of" + UI.FormatAsLink(Strings.NAME, Dark_Moon_GalaxyFruitConfig.Id) + ",the bowl is full of oxyfruit, so delicious!";


        public static LocString SEEDNAME = "Carbonaceous grass stake seeds";
        public static LocString DESCRIPTION3 = "This is a CO2 loving " + UI.FormatAsLink("plant ", "plant ") + "  They can be grown on soil bricks\n\nAnd their fruits give off oxygen";
        public static LocString DESCRIPTION4 = "These were put together but turned out to be a seed ！！！！";
    }
}
