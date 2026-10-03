using System;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	[Serializable]
	public class BoolAttribute : NamedThemeAttribute<bool>
	{
		public abstract class Setter : MonoBehaviour
		{
			public abstract void Initialize(BoolAttribute attrib, Action<bool> onChange);
		}

		[Header("Dependencies")]
		[SerializeField]
		private Setter togglePrefab;

		public override object Data => null;

		public override void Initialize(SettingsWrapper settings, string key, int groups, Action<bool> onChange)
		{
		}

		protected override void OnSettingsChanged(bool value)
		{
		}

		public override RectTransform GetSettingsUIObject()
		{
			return null;
		}
	}
}
