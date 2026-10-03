using System.Collections.Generic;
using UnityEngine;

public class ThemeRepository : ScriptableObject
{
	[SerializeField]
	private List<Theme> themePrefabs;

	private Dictionary<string, Theme> IdentifierToTheme;

	public static ThemeRepository Instance { get; private set; }

	public bool ThemesEnabled { get; set; }

	public int CurrentThemeWoid => 0;

	public Theme CurrentThemeVisualization => null;

	public string CurrentThemeIdentifier => null;

	public bool SkyboxOverride => false;

	public bool ThemeIsActive => false;

	private ThemeWorldObject CurrentTheme => null;

	public void Initialize()
	{
	}

	public static void Destroy()
	{
	}

	public Theme GetThemePrefab(string identifier)
	{
		return null;
	}

	public Theme CreateTemporaryThemeVisualization(string identifier)
	{
		return null;
	}

	public void DestroyTemporary(Theme theme)
	{
	}
}
