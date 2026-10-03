using System;
using MV.WorldObject.ThemesData;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelection : MonoBehaviour
{
	public static class CallbackHandler
	{
		public static Action<ThemeData[]> OnThemeDataReceived;
	}

	[SerializeField]
	private ThemeRepository themeRepo;

	[SerializeField]
	private ThemeSelectionButton buttonPrefab;

	[SerializeField]
	private Button themeRemovalButtonPrefab;

	[SerializeField]
	private RectTransform themeButtonContainer;

	[SerializeField]
	private Text themeDescription;

	[SerializeField]
	private Image close;

	[SerializeField]
	private Image back;

	public const string menuDescription = "_(\"Hover over a theme to know more about it. Click it to see it in game.\")";

	public string currentDescription;

	private ThemeMenuController menuController;

	private Theme previewTheme;

	public string ThemeDescription
	{
		set
		{
		}
	}

	private Theme PreviewTheme
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void InitializeWithBackButton(ThemeMenuController menuController)
	{
	}

	public void Initialize(ThemeMenuController menuController)
	{
	}

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	private void CreateThemeButtons(ThemeData[] data)
	{
	}

	private void LoadTheme(string identifier, ThemeData data)
	{
	}

	private void ShowThemeRemovalWarning()
	{
	}

	private void OnThemeRemovalWarningResolved(bool answer, ConfirmationPopup popup)
	{
	}

	private void GoBackToSettings()
	{
	}

	private void LocalizeAndSetDescriptionText()
	{
	}
}
