using System.Collections.Generic;
using ThemeAttributes;
using UnityEngine;

namespace ThemeSettings
{
	public abstract class SettingsWrapper
	{
		protected Dictionary<object, object> settingsData;

		private List<ThemeAttribute> attributes;

		private int activeAttributeGroup;

		private IMenu menu;

		public Dictionary<object, object> Data => null;

		public int ActiveAttributeGroup => 0;

		public RectTransform[] SettingsUI => null;

		public abstract void CommitChanges();

		public void Initialize()
		{
		}

		public void Add(ThemeAttribute attrib)
		{
		}

		public T GetValueForAttribute<T>(ThemeAttribute attrib)
		{
			return default;
		}

		public void UpdateData(string key, object val)
		{
		}

		public void DisableAttributeGroups(int groupsFlag)
		{
		}

		public void EnableAttributeGroups(int groupsFlag)
		{
		}

		public void SetAttributeGroups(int groupsFlag)
		{
		}

		public void SubscribeToSettingsUI(IMenu menu)
		{
		}

		public void UnsubscribeToSettingsUI()
		{
		}
	}
}
