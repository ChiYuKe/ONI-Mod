using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using PeterHan.PLib.Options;
using System.Threading.Tasks;
using static KAnim;
using UnityEngine;
using Klei.AI;
using static STRINGS.BUILDINGS.PREFABS.CANVAS.FACADES;
using System.Text.RegularExpressions;

namespace penKo.低温蒸汽喷孔
{
    [HarmonyPatch(typeof(GeyserGenericConfig), "GenerateConfigs")]
    public class 低温蒸汽喷孔Config
    {

        private static void Prefix()
        {/*   SingletonOptions<Settings>.Instance.ColdBreezeToTile;
            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams(
                "geyser_gas_steam_kanim",
                2, 4,
                new GeyserConfigurator.GeyserType(
                    //字符串 id，SimHashes 元素， GeyserShape 形状，
                    "steam", SimHashes.Oxygen, GeyserConfigurator.GeyserShape.Gas,
                    //温度， 每s产出最小速率  每s产出最大速率  最大压力  最小活跃时间长度 最大活跃时间长度  最小迭代百分比 最大迭代百分比
                    83.15f, 10f,           20000f,       500000f,  6000f,        114000f,          0.1f,        低温蒸汽喷孔.喷发期占比MAX,
                    // 最小休眠期长度 最大休眠期长度    最小年百分比  最大年百分比    间歇泉温度  " "  是通用间歇泉
                    15000f,          135000f,         0.4f,        低温蒸汽喷孔.活跃期占比MAX,       272.15f, ""), true));
            */
            int num = 低温蒸汽喷孔.产物;

            List<GeyserGenericConfig.GeyserPrefabParams> list = new List<GeyserGenericConfig.GeyserPrefabParams>();
            list.Add(new GeyserGenericConfig.GeyserPrefabParams("geyser_gas_steam_kanim", 2, 4, new GeyserConfigurator.GeyserType("steam", Spout_Tag.testTag[num], GeyserConfigurator.GeyserShape.Gas, 低温蒸汽喷孔.温度, 低温蒸汽喷孔.最低平均产率, 低温蒸汽喷孔.最高平均产率, 低温蒸汽喷孔.最大压力, 低温蒸汽喷孔.最低喷发周期, 1140f, 低温蒸汽喷孔.喷发期占比, 低温蒸汽喷孔.喷发期占比MAX, 低温蒸汽喷孔.最小活跃期, 135000f, 低温蒸汽喷孔.活跃期占比, 低温蒸汽喷孔.活跃期占比MAX, 372.15f, ""), true));
        }
    }
}
