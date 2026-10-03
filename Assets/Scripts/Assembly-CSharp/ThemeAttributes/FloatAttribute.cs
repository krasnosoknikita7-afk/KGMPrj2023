using System;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	[Serializable]
	public class FloatAttribute : NamedThemeAttribute<float>
	{
		public abstract class Setter : MonoBehaviour
		{
			public abstract void Initialize(FloatAttribute attrib, Action<float> onChange);
		}

		[SerializeField]
		private float min;

		[SerializeField]
		private float max;

		[Header("Dependencies")]
		[SerializeField]
		private Setter sliderPrefab;

		public override object Data => null;

		public float Min => 0f;

		public float Max => 0f;

		public override void Initialize(SettingsWrapper settings, string key, int groups, Action<float> onChange)
		{
		}

		public float Constrain(float value)
		{
			return 0f;
		}

		protected override void OnSettingsChanged(float value)
		{
		}

		public override RectTransform GetSettingsUIObject()
		{
			return null;
		}
	}
}
