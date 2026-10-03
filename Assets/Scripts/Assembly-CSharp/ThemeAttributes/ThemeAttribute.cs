using System;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	public abstract class ThemeAttribute
	{
		private SettingsWrapper themeSettings;

		protected const string valueOutOfBoundsMsg = "Theme attribute is out of expected range.";

		public string Key { get; private set; }

		public int Groups { get; private set; }

		public abstract object Data { get; }

		public abstract RectTransform GetSettingsUIObject();

		public abstract void ApplyValue();

		protected virtual void Initialize(SettingsWrapper settings, string key, int groups)
		{
		}

		protected void UpdateSettings(string key, object value)
		{
		}
	}
	public abstract class ThemeAttribute<T> : ThemeAttribute
	{
		[Header("Configuration")]
		[SerializeField]
		protected T value;

		protected Action<T> themeCallback;

		public T Value => default;

		public virtual void Initialize(SettingsWrapper settings, string key, int groups, Action<T> onChange)
		{
		}

		protected abstract void OnSettingsChanged(T arg);

		public override void ApplyValue()
		{
		}
	}
}
