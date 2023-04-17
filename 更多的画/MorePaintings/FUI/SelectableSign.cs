using System;
using System.Collections.Generic;
using KSerialization;

namespace more_paintings
{
	[SerializationConfig(MemberSerialization.OptIn)]
	internal class SelectableSign : KMonoBehaviour
	{
        /*在OnSpawn()方法中，该类首先检查AnimationNames属性是否为null或为空，如果是，则不执行任何操作。
         * 否则，它检查selectedIndex是否大于或等于AnimationNames的计数，如果是，则将selectedIndex设置为0。最
         * 后，它通过调用kbac.Play()方法播放AnimationNames中的selectedIndex指定的动画。*/
        protected override void OnSpawn()
		{
			bool flag = this.AnimationNames == null || this.AnimationNames.Count == 0;
			if (!flag)
			{
				bool flag2 = this.selectedIndex >= this.AnimationNames.Count;
				if (flag2)
				{
					this.selectedIndex = 0;
				}
				this.kbac.Play(this.AnimationNames[this.selectedIndex], KAnim.PlayMode.Once, 1f, 0f);
			}
		}


        /*在SetVariant()方法中，该类首先检查AnimationNames属性中是否包含指定的变体名称。如果不包含，则不执行任何操作。
         * 否则，它通过调用AnimationNames.FindIndex()方法查找指定变体的索引，并将其赋值给selectedIndex属性。
         * 然后，它通过调用kbac.Play()方法播放指定的动画。*/
        /*总体来说，该类的作用是允许在游戏运行时选择并播放一组动画。AnimationNames属性用于存储所有可用的动画名称，selectedIndex属性用于存储当前选择的动画的索引。
         * 通过调用SetVariant()方法，可以选择并播放指定的动画。OnSpawn()方法则在对象被生成时执行，根据selectedIndex播放指定的动画。
			需要注意的是，由于该类使用了OptIn的序列化配置，只有被标记为[Serialize]的字段才会被序列化和保存。如果要添加新的字段或属性，
		 请确保将它们标记为[Serialize]，以便正确地保存和加载它们的值。*/
        public void SetVariant(string variant)
		{
			bool flag = !this.AnimationNames.Contains(variant);
			if (!flag)
			{
				this.selectedIndex = this.AnimationNames.FindIndex((string str) => str == variant);
				this.kbac.Play(variant, KAnim.PlayMode.Once, 1f, 0f);
			}
		}

		[MyCmpGet]
		private KBatchedAnimController kbac;

		[Serialize]
		public List<string> AnimationNames = new List<string>();

		[Serialize]
		public int selectedIndex;
	}
}
