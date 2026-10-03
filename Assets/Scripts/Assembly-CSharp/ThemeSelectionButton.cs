using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ThemeSelectionButton : TextButton
{
	[SerializeField]
	private RawImage background;

	[SerializeField]
	private GameObject nameLabel;

	[SerializeField]
	private RectTransform previewImageArea;

	[Header("Configuration")]
	[SerializeField]
	private Color selectedColor;

	private Color normalColor;

	private ThemeSelection selectionMenu;

	private Theme themePrefab;

	private bool themeInUse;

	private string themeName;

	public void Initialize(ThemeSelection selectionMenu, Theme themePrefab, UnityAction buttonClickedCB, int price, int levelReq, bool alreadyInUse)
	{
	}

	public void EventTriggerCB_MouseEnter()
	{
	}

	public void EventTriggerCB_MouseExit()
	{
	}

	private void LocalizeAndSetThemeName()
	{
	}
}
