using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class TeamMenuButton : MonoBehaviour
{
	[SerializeField]
	private TeamMenu teamMenuPrefab;

	[SerializeField]
	private GameObject buttonEnabler;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void AvatarStateChanged(SpawnRoleModeType state)
	{
	}

	private void TeamChanged(object sender, TeamEventArgs eventArgs)
	{
	}

	private void SetButtonIsActive()
	{
	}

	public void ShowTeamMenu()
	{
	}
}
