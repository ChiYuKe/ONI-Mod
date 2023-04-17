using System;
using System.Collections.Generic;
using UnityEngine;

namespace more_paintings
{
	internal class SignSideScreen : SideScreenContent
	{
        /*IsValidForTarget方法用于检查传递给它的GameObject对象是否有SelectableSign组件，如果有则返回true，否则返回false。*/
        public override bool IsValidForTarget(GameObject target)
		{
			return target.GetComponent<SelectableSign>() != null;
		}

        /*OnSpawn方法被调用来初始化SideScreenContent的子类，它将flipButton和debugVictoryButton两个游戏对象设为不活跃状态。*/
        protected override void OnSpawn()
		{
			base.OnSpawn();
			this.flipButton.SetActive(false);
			this.debugVictoryButton.SetActive(false);
		}

        /*OnPrefabInit方法在预制件被实例化时被调用，它将titleKey设为“UI”，并且获取了stateButtonPrefab、buttonContainer、debugVictoryButton、flipButton这些游戏对象。*/
        protected override void OnPrefabInit()
		{
			base.OnPrefabInit();
			this.titleKey = "UI";
			this.stateButtonPrefab = base.transform.Find("ButtonPrefab").gameObject;
			this.buttonContainer = base.transform.Find("Content/Scroll/Grid").GetComponent<RectTransform>();
			this.debugVictoryButton = base.transform.Find("Butttons/Button").gameObject;
			this.flipButton = base.transform.Find("Butttons/FlipButton").gameObject;
		}

        /*SetTarget方法被调用来设置当前标志物件的GameObject对象，它还调用了GenerateStateButtons方法来生成UI中的按钮。*/
        public override void SetTarget(GameObject target)
		{
			base.SetTarget(target);
			this.target = target.GetComponent<SelectableSign>();
			base.gameObject.SetActive(true);
			this.GenerateStateButtons();
		}

        /*GenerateStateButtons方法用来生成UI中的按钮，它通过遍历当前标志物件的所有动画名称来创建按钮，并将其添加到UI中。*/
        private void GenerateStateButtons()
		{
			this.ClearButtons();
			KAnimFile animFile = this.target.GetComponent<KBatchedAnimController>().AnimFiles[0];
			using (List<string>.Enumerator enumerator = this.target.AnimationNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string anim = enumerator.Current;
					this.AddButton(animFile, anim, anim, delegate
					{
						this.target.SetVariant(anim);
					});
				}
			}
		}


        /*AddButton方法用于添加单个按钮到UI中，它需要提供一个KAnimFile、一个动画名称和一个委托，以便在单击按钮时调用。它使用Util.KInstantiateUI方法创建UI游戏对象，并设置它的图像和委托。*/
        private void AddButton(KAnimFile animFile, string animName, LocString tooltip, System.Action onClick)
		{
			GameObject gameObject = Util.KInstantiateUI(this.stateButtonPrefab, this.buttonContainer.gameObject, true);
			KButton kbutton;
			bool flag = gameObject.TryGetComponent<KButton>(out kbutton);
			if (flag)
			{
				kbutton.onClick += onClick;
				kbutton.fgImage.sprite = Def.GetUISpriteFromMultiObjectAnim(animFile, animName, false, "");
			}
			this.buttons.Add(gameObject);
		}

        /*ClearButtons方法用于清除UI中所有按钮，并将flipButton和debugVictoryButton两个游戏对象设为不活跃状态。*/
        private void ClearButtons()
		{
			foreach (GameObject original in this.buttons)
			{
				Util.KDestroyGameObject(original);
			}
			this.buttons.Clear();
			this.flipButton.SetActive(false);
			this.debugVictoryButton.SetActive(false);
		}


        /*buttonContainer是用于放置所有按钮的容器。
		stateButtonPrefab是用于创建按钮的预制件。
		debugVictoryButton和flipButton是两个额外的按钮游戏对象，目前没有使用。
		buttons是一个存储所有创建的按钮游戏对象的列表。
		target是当前选中的标志物件的SelectableSign组件。*/
        [SerializeField]
		private RectTransform buttonContainer;

		private GameObject stateButtonPrefab;

		private GameObject debugVictoryButton;

		private GameObject flipButton;

		private readonly List<GameObject> buttons = new List<GameObject>();

		private SelectableSign target;

		public const string SCREEN_TITLE_KEY = "UI";
	}
}
