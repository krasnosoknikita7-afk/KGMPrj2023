using System.Collections.Generic;
using MV.WorldObject.ThemesData;
using UnityEngine;

public class ThemePreviewSettingsMenu : ThemeSettingsMenuBase
{
	[SerializeField]
	private RectTransform topArea;

	[SerializeField]
	private SwitchThemeButton switchThemeButtonPrefab;

	private Theme previewTheme;

	private int previewID;

	private string previewDisplayName;

	private ThemeMenuController menuController;

	private ConfirmationPopup openPopup;

	private ThemeSettingsSideBar sideBar;

	private ThemeData ThemeData { get; set; }

	public void Initialize(Theme theme, ThemeData data, ThemeMenuController menuController)
	{
	}

	private void SwitchThemeButtonClicked(int themeID, int levelReq)
	{
	}

	private void DisplayInsufficientLevelNotification(int levelReq)
	{
	}

	private void DisplayInsufficientGoldNotification(int price)
	{
	}

	private void DisplaySkyboxWarning()
	{
	}

	private void OnSkyboxWarningResolved(bool b, ConfirmationPopup popup)
	{
	}

	private void DisplayThemeSwitchWarning()
	{
	}

	private void OnThemeSwitchWarningResolved(bool b, ConfirmationPopup popup)
	{
	}

	private void OnPurchaseResponse(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}
}
