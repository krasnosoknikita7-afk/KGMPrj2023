using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLists : MonoBehaviour
{
	private class ScoreSorter : IComparer<MVPlayer>
	{
		public int Compare(MVPlayer data1, MVPlayer data2)
		{
			return 0;
		}

		private int PlayerValue(MVPlayer data)
		{
			return 0;
		}
	}

	private PlayerLists playerListsPrefab;

	[SerializeField]
	private PlayerList playerListPrefab;

	[SerializeField]
	private GridLayoutGroup gridGroup;

	[SerializeField]
	private Vector2 cellSize1Team;

	[SerializeField]
	private Vector2 cellSize2Teams;

	[SerializeField]
	private Vector2 cellSize4Teams;

	private GameStatCounterType typeToDisplay;

	public void Initialize(PlayerLists playerListsPrefab, GameStatCounterType typeToDisplay)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReCreate()
	{
	}

	private void CreatePlayerLists(IEnumerable<MVPlayer> players, List<MVTeam> teams)
	{
	}

	private PlayerList CreatePlayerList(MVTeam team, int score)
	{
		return null;
	}

	private void SortPlayerListsAfterScore(Dictionary<MVTeam, PlayerList> playerLists, List<MVTeam> teams, GameStatCounterType typeToDisplay)
	{
	}

	private Dictionary<MVTeam, List<MVPlayer>> GetSortedTeamLists(IEnumerable<MVPlayer> players, List<MVTeam> teams)
	{
		return null;
	}
}
