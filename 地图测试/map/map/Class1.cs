using System;
using HarmonyLib;
using Pholib;

namespace map
{
    // Token: 0x02000006 RID: 6
    [HarmonyPatch(typeof(Game))]
    [HarmonyPatch("OnSpawn")]
    public class AfterGameLoad_Patch
    {
        private static KAnimFile GetWorldAnim()
        {

            if (Utilities.IsOnCluster(WorldAdds.EarthId))
            {
                return Assets.GetAnim("moon_kanim");
            }
            return null;
        }

        public static void Postfix()
        {
            if (MapConfig.earthAnimController != null)
            {
                if (AfterGameLoad_Patch.originalAnim == null)
                {
                    AfterGameLoad_Patch.originalAnim = new KAnimFile[]
                    {
                Assets.GetAnim("earth_kanim")
                    };
                }
                MapConfig.earthAnimController.AnimFiles = new KAnimFile[]
                {
            AfterGameLoad_Patch.GetWorldAnim()
                };
                if (AfterGameLoad_Patch.normalSize == 0f || MapConfig.earthAnimController.animScale < AfterGameLoad_Patch.normalSize)
                {
                    AfterGameLoad_Patch.normalSize = MapConfig.earthAnimController.animScale;
                    MapConfig.earthAnimController.animScale = MapConfig.earthAnimController.animScale * 5f;
                    return;
                }
            }
            else
            {
                Debug.Assert(AfterGameLoad_Patch.originalAnim != null, "原始动画不应为空.");
                MapConfig.earthAnimController.AnimFiles = AfterGameLoad_Patch.originalAnim;
                MapConfig.earthAnimController.animScale = MapConfig.earthAnimController.animScale / 5f;
            }
        }

        private const int sizeScale = 5;
        private static KAnimFile[] originalAnim;
        private static float normalSize;
    }

}
