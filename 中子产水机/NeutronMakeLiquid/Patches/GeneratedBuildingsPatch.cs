using ElementConvert.ElementConvertConfig;
using HarmonyLib;
using STRINGS;

namespace ElementConvert.Patches
{
    class GeneratedBuildingsPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        public static class GeneratedBuildings_LoadGeneratedBuildings_Patch
        {
            // 此代码将插入到 GeneratedBuildings.LoadGeneratedBuildings 的顶部
            public static void Prefix()
            {
                //下面两行主要是由  BuildMenu : KScreen 管理的
                // 将元素置换仪添加到菜单
                ModUtil.AddBuildingToPlanScreen("Refining", ElementConvertConfig.NeutronMakeLiquidConfig.ID);
                // 使其可研究
                Db.Get().Techs.Get("Catalytics").unlockedItemIDs.Add(ElementConvertConfig.NeutronMakeLiquidConfig.ID);

                // 给它一个名字和描述
                // 字符串 key-s ID 部分必须是您的 item-s ID，全部大写
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_NEUTRONMAKELIQUID.NAME", "中子液体提取仪");
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_NEUTRONMAKELIQUID.DESC", "话不多说，打个郊县，3秒钟教你学会打胶!!!");
                Strings.Add("STRINGS.BUILDINGS.PREFABS.MYMOD_NEUTRONMAKELIQUID.EFFECT", $"中子液体提取仪，其内部超高压、超高温，还有超级精密的控制，在这种环境下，内部的元素分子会被我们想要的结构进行被重构");
            }
        }
    }
}
