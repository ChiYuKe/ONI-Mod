using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace more_paintings
{
	internal class FUI_SideScreen
	{
        /*处理侧边栏（SideScreen） 
         * 方法 AddClonedSideScreen<T> 用于添加一个克隆的侧边栏，参数 name 为新的侧边栏的名字，originalName 为原始侧边栏的名字，
         * originalType 为原始侧边栏的类型。该方法会将原始侧边栏的内容复制到新的侧边栏，并添加到游戏中。 */
        public static void AddClonedSideScreen<T>(string name, string originalName, Type originalType)
		{
			List<DetailsScreen.SideScreenRef> list;
			GameObject contentBody;
			bool elements = FUI_SideScreen.GetElements(out list, out contentBody);
			if (elements)
			{
				SideScreenContent prefab = FUI_SideScreen.Copy<T>(FUI_SideScreen.FindOriginal(originalName, list), contentBody, name, originalType);
				list.Add(FUI_SideScreen.NewSideScreen(name, prefab));
			}
		}

        //方法 GetElements 用于获取游戏中的侧边栏列表和侧边栏内容的 GameObject 对象，并返回一个布尔值表示是否成功获取。
        private static bool GetElements(out List<DetailsScreen.SideScreenRef> screens, out GameObject contentBody)
		{
			Traverse traverse = Traverse.Create(DetailsScreen.Instance);
			screens = traverse.Field("sideScreens").GetValue<List<DetailsScreen.SideScreenRef>>();
			contentBody = traverse.Field("sideScreenContentBody").GetValue<GameObject>();
			return screens != null && contentBody != null;
		}

        /*方法 Copy<T> 用于将原始侧边栏的内容复制到新的侧边栏中，参数 original 为原始侧边栏的 SideScreenContent 对象，contentBody 为新的侧边栏的 GameObject 对象，
         * name 为新的侧边栏的名字，originalType 为原始侧边栏的类型。该方法会将原始侧边栏的 GameObject 对象实例化到新的侧边栏中，并移除原始侧边栏的类型组件，
         * 并添加新的类型组件，最后返回新的侧边栏的 SideScreenContent 对象。*/
        private static SideScreenContent Copy<T>(SideScreenContent original, GameObject contentBody, string name, Type originalType)
		{
			GameObject gameObject = Util.KInstantiateUI<SideScreenContent>(original.gameObject, contentBody, false).gameObject;
			UnityEngine.Object.Destroy(gameObject.GetComponent(originalType));
			SideScreenContent sideScreenContent = gameObject.AddComponent(typeof(T)) as SideScreenContent;
			sideScreenContent.name = name.Trim();
			gameObject.SetActive(false);
			return sideScreenContent;
		}

        /*方法 FindOriginal 用于根据侧边栏的名字在侧边栏列表中查找对应的侧边栏的 SideScreenContent 对象，并返回该对象。如果找不到该侧边栏，则会输出一个警告信息并返回 null。*/
        private static SideScreenContent FindOriginal(string name, List<DetailsScreen.SideScreenRef> screens)
		{
			SideScreenContent screenPrefab = screens.Find((DetailsScreen.SideScreenRef s) => s.name == name).screenPrefab;
			bool flag = screenPrefab == null;
			if (flag)
			{
				global::Debug.LogWarning("Could not find a sidescreen with the name " + name);
                global::Debug.LogWarning("找不到具有该名称的侧屏 " + name);
            }
			return screenPrefab;
		}

        /*方法 NewSideScreen 用于创建一个新的侧边栏对象，参数 name 为新的侧边栏的名字，prefab 为新的侧边栏的 SideScreenContent 对象。
         * 该方法会返回一个新的 DetailsScreen.SideScreenRef 对象，该对象包含了新的侧边栏的名字、偏移量和对象。*/
        private static DetailsScreen.SideScreenRef NewSideScreen(string name, SideScreenContent prefab)
		{
			return new DetailsScreen.SideScreenRef
			{
				name = name,
				offset = Vector2.zero,
				screenPrefab = prefab
			};
		}

        /*工具提示（ToolTip）  方法 AddSimpleToolTip 用于为一个 GameObject 添加一个简单的工具提示，参数 gameObject 为要添加工具提示的 GameObject 对象，
         * message 为工具提示的内容，alignCenter 表示工具提示是否居中对齐，wrapWidth 表示工具提示的最大宽度。该方法会将 ToolTip 组件添加到 GameObject 中，
         * 并设置工具提示的位置、大小和内容。如果 GameObject 中已经存在 ToolTip 组件，则不会添加新的工具提示，并输出一个日志信息。该方法最后会返回 ToolTip 组件。*/
        public static ToolTip AddSimpleToolTip(GameObject gameObject, string message, bool alignCenter = false, float wrapWidth = 0f)
		{
			bool flag = gameObject.GetComponent<ToolTip>() != null;
			ToolTip result;
			if (flag)
			{
				global::Debug.Log("GO already had a tooltip! skipping"); 
                global::Debug.Log("GO 已经有了工具提示！跳过" );
                result = null;
			}
			else
			{
				ToolTip toolTip = gameObject.AddComponent<ToolTip>();
				toolTip.tooltipPivot = (alignCenter ? new Vector2(0.5f, 0f) : new Vector2(1f, 0f));
				toolTip.tooltipPositionOffset = new Vector2(0f, 20f);
				toolTip.parentPositionAnchor = new Vector2(0.5f, 0.5f);
				bool flag2 = wrapWidth > 0f;
				if (flag2)
				{
					toolTip.WrapWidth = wrapWidth;
					toolTip.SizingSetting = ToolTip.ToolTipSizeSetting.MaxWidthWrapContent;
				}
				ToolTipScreen.Instance.SetToolTip(toolTip);
				toolTip.SetSimpleTooltip(message);
				result = toolTip;
			}
			return result;
		}
	}
}
