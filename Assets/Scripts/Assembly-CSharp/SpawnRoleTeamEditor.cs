using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnRoleTeamEditor : MonoBehaviour
{
	[Serializable]
	private struct SpawnRoleTeamButton
	{
		public GameObject buttonSelected;

		public GameObject buttonNotSelected;

		public Text buttonSelectedText;

		public Text buttonNotSelectedText;

		public MVTeam team;
	}

	[SerializeField]
	private List<SpawnRoleTeamButton> teamButtons;

	private UnityAction<MVTeam> onTeamChangeCallback;

	public void Initialize(MVTeam spawnRolesTeam, UnityAction<MVTeam> onTeamChangeCallback)
	{
	}

	public void SelectRedTeam()
	{
	}

	public void SelectBlueTeam()
	{
	}

	public void SelectYellowTeam()
	{
	}

	public void SelectGreenTeam()
	{
	}

	private void SelectTeam(MVTeam teamSelected)
	{
	}
}
