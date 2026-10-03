using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class GUILoginHandler : MonoBehaviour
{
	private struct PlanetData
	{
		public readonly int planetID;

		public readonly int profileID;

		public PlanetData(int planet, int profile)
		{
			planetID = 0;
			profileID = 0;
		}
	}

	private enum DevServerTarget
	{
		Dev = 0,
		Test = 1,
		Local = 2
	}

	[SerializeField]
	private KoGaMaSettingsContainer kogamaSettings;

	[SerializeField]
	private Dropdown serverDropdown;

	[SerializeField]
	private InputField serverIp;

	[SerializeField]
	private InputField profileIdTextField;

	[SerializeField]
	private InputField planetIdTextField;

	[SerializeField]
	private Toggle disableCacheToggle;

	[SerializeField]
	private Toggle touchToggle;

	[SerializeField]
	private Dropdown planetDropdown;

	[SerializeField]
	private Dropdown profileDropdown;

	[SerializeField]
	private Button buildButton;

	[SerializeField]
	private Button avatarEditButton;

	private string _profileId;

	private string _serverip;

	private string _planetId;

	private readonly Dictionary<string, PlanetData> defaultPlanetData;

	private readonly Dictionary<string, object> gameSessionData;

	private string playerPrefKey;

	private static string GetIPFromDevServerTarget(DevServerTarget devTarget)
	{
		return null;
	}

	protected void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetupServerDropdown(int savedChoice)
	{
	}

	public void OnProfileDropdownChanged()
	{
	}

	public void OnPlanetDropdownChanged()
	{
	}

	private void SetupPlanetID()
	{
	}

	private void SetupProfileID()
	{
	}

	private void Update()
	{
	}

	public void ComboboxChanged(int index)
	{
	}

	public void UIDropdownChanged(int index)
	{
	}

	public void EnterPlayOnClick()
	{
	}

	public void EnterEditOnClick()
	{
	}

	public void EnterCharacterEditOnClick()
	{
	}

	public void Embedded(bool isEmbedded)
	{
	}

	public void Caching()
	{
	}

	public void TouchMode()
	{
	}

	private void StartGame(MVGameMode gameMode)
	{
	}

	private void SetValuesToPrefOrDefault()
	{
	}

	private void UpdatePrefValuesIfChanged()
	{
	}

	private string GetPrefOrDefault(string prefName, string target)
	{
		return null;
	}

	private string UpdateIfChanged(string prefName, string current, string target)
	{
		return null;
	}
}
