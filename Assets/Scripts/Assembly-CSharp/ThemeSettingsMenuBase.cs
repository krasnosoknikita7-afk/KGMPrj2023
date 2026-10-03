using ThemeSettings;
using UnityEngine;

public abstract class ThemeSettingsMenuBase : MonoBehaviour, IMenu
{
	[SerializeField]
	protected ThemeSettingsSideBar sideBarPrefab;

	[SerializeField]
	protected RectTransform settingsArea;

	[SerializeField]
	protected RectTransform controllerArea;

	private Theme theme;

	private RectTransform content;

	protected void Initialize(Theme theme, RectTransform content)
	{
	}

	public void Refresh()
	{
	}

	protected void OnDestroy()
	{
	}
}
