using System;
using System.Collections.Generic;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	[Serializable]
	public class ColorAttribute : NamedThemeAttribute<Color>
	{
		public abstract class Setter : MonoBehaviour
		{
			public abstract void Initialize(ColorAttribute attrib, Action<Color> onChange);
		}

		private class ColorKeys
		{
			public const string r = "Red";

			public const string g = "Green";

			public const string b = "Blue";

			public const string a = "Alpha";
		}

		[SerializeField]
		[Header("Dependencies")]
		private Setter prefab;

		public override object Data => null;

		public override void Initialize(SettingsWrapper settings, string key, int groups, Action<Color> onChange)
		{
		}

		private Dictionary<object, object> ToSerializable(Color c)
		{
			return null;
		}

		private static Color ConvertToColor(Dictionary<object, object> value)
		{
			return default;
		}

		private float Constrain(float value)
		{
			return 0f;
		}

		private Color Constrain(Color value)
		{
			return default;
		}

		protected override void OnSettingsChanged(Color value)
		{
		}

		public override RectTransform GetSettingsUIObject()
		{
			return null;
		}
	}
}
