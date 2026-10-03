using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class PlayerListSelector : MonoBehaviour
{
	[SerializeField]
	private PlayerListSelectorButton teamSelectButtonPrefab;

	private Dictionary<MVTeam, PlayerList> playerLists;

	public void Setup(Dictionary<MVTeam, PlayerList> playerLists)
	{
	}

	public void SetActiveTeam(MVTeam team)
	{
	}
}
