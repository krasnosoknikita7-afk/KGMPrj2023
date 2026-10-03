using UnityEngine;

public class ThemeSettingsMenu : ThemeSettingsMenuBase
{
	[SerializeField]
	private TextButton browseThemesButton;

	private ThemeSettingsSideBar sideBar;

	public void Initialize(ThemeMenuController menuController, Theme theme)
	{
	}
}
