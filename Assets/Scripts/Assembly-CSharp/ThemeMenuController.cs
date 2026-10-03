using MV.WorldObject.ThemesData;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThemeMenuController : MonoBehaviour, ThemeMenuButton.IClickHandler, IEventSystemHandler
{
	[SerializeField]
	private ThemeSelection selectionPrefab;

	[SerializeField]
	private ThemeSettingsMenu settingsPrefab;

	[SerializeField]
	private ThemePreviewSettingsMenu previewSettingsPrefab;

	public void OpenThemesMenu()
	{
	}

	public void OpenSelection()
	{
	}

	public void OpenSettings(Theme theme)
	{
	}

	public void OpenSettingsForPreview(Theme theme, ThemeData entry)
	{
	}
}
