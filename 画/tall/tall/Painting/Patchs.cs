using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tall.Painting
{
    class Painting
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        public static class Painting_erect
        {
            // 此代码将插入到 GeneratedBuildings.LoadGeneratedBuildings 的顶部
            public static void Prefix()
            {
                //下面两行主要是由  BuildMenu : KScreen 管理的 CanvasTall
                //Techs : ResourceSet<Tech>
                // 将元素置换仪添加到菜单
                ModUtil.AddBuildingToPlanScreen("Decor", New_Painting_erect.ID);
                // 使其可研究
                Db.Get().Techs.Get("RenaissanceArt").unlockedItemIDs.Add(New_Painting_erect.ID);

                // 给它一个名字和描述
                // 字符串 key-s ID 部分必须是您的 item-s ID，全部大写
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_CANVASTALL.NAME", "元素重构仪");
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_CANVASTALL.DESC", "话不多说，打个郊县，3秒钟教你学会打胶!!!");
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_CANVASTALL.EFFECT", $"元素重构仪，其内部超高压、超高温，还有超级精密的控制，在这种环境下，内部的元素分子会被我们想要的结构进行被重构");
            }
        }
    }
}
