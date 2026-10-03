using System;
using ThemeSettings;
using UnityEngine;

namespace ThemeAttributes
{
	public abstract class NamedThemeAttribute<T> : ThemeAttribute<T>
	{
		[SerializeField]
		private string name;

		public string Name => null;

		public override void Initialize(SettingsWrapper settings, string key, int groups, Action<T> onChange)
		{
		}

		public void LanguageLoadedCallback()
		{
		}

		protected void OnValidate()
		{
		}

		private string Validate(string str)
		{
			return null;
		}
	}
}
