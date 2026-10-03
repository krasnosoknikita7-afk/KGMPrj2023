using System;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	[Serializable]
	public class IntAttribute : NamedThemeAttribute<int>
	{
		public abstract class Setter : MonoBehaviour
		{
			public abstract void Initialize(IntAttribute attrib, Action<int> onChange);
		}

		[SerializeField]
		private int min;

		[SerializeField]
		private int max;

		[SerializeField]
		[Header("Dependencies")]
		private Setter prefab;

		public override object Data => null;

		public int Min => 0;

		public int Max => 0;

		public override void Initialize(SettingsWrapper settings, string key, int groups, Action<int> onChange)
		{
		}

		private int Constrain(int value)
		{
			return 0;
		}

		protected override void OnSettingsChanged(int value)
		{
		}

		public override RectTransform GetSettingsUIObject()
		{
			return null;
		}
	}
}
