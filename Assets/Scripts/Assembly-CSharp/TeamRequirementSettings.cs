using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TeamRequirementSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsButton buttonTeamNone;

	[SerializeField]
	private SettingsButton buttonTeamBlue;

	[SerializeField]
	private SettingsButton buttonTeamRed;

	[SerializeField]
	private SettingsButton buttonTeamGreen;

	[SerializeField]
	private SettingsButton buttonTeamYellow;

	[SerializeField]
	private Text buttonTeamBlueName;

	[SerializeField]
	private Text buttonTeamRedName;

	[SerializeField]
	private Text buttonTeamGreenName;

	[SerializeField]
	private Text buttonTeamYellowName;

	[SerializeField]
	private Outline outlineTeamNone;

	[SerializeField]
	private Outline outlineTeamRed;

	[SerializeField]
	private Outline outlineTeamBlue;

	[SerializeField]
	private Outline outlineTeamGreen;

	[SerializeField]
	private Outline outlineTeamYellow;

	private Outline currentOutline;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
