using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeamEditorSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsInputField blueTeam;

	[SerializeField]
	private SettingsInputField redTeam;

	[SerializeField]
	private SettingsInputField greenTeam;

	[SerializeField]
	private SettingsInputField yellowTeam;

	[SerializeField]
	private GameObject blueTeamButton;

	[SerializeField]
	private GameObject redTeamButton;

	[SerializeField]
	private GameObject greenTeamButton;

	[SerializeField]
	private GameObject yellowTeamButton;

	private int woID;

	private Dictionary<object, object> teamData;

	public void Initialize(int woID, GameObject root)
	{
	}

	private void InitInputfield(SettingsInputField inputField, GameObject button, MVTeam team)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private void SetActiveButtons(Dictionary<object, object> teamData)
	{
	}
}
