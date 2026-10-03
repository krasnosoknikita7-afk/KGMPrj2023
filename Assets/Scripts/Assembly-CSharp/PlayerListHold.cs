using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class PlayerListHold : PlayerListBase
{
	private struct PlayerElementHoldData
	{
		public int score;

		public PlayerElementHold playerElement;
	}

	[Serializable]
	private class ScoreIconDef
	{
		public GameStatCounterType scoreType;

		public GameObject icon;
	}

	private int score;

	private int playerCount;

	private MVTeam team;

	private GameStatCounterType typeToDisplay;

	private List<PlayerElementHoldData> playerElementList;

	[SerializeField]
	private RectTransform contentPanel;

	[SerializeField]
	private PlayerElementHold playerElementPrefab;

	[SerializeField]
	private TeamTab teamTab;

	[SerializeField]
	private List<ScoreIconDef> winningConditionIcons;

	public override MVTeam Team => MVTeam.Blue;

	public override int PlayerCount => 0;

	public override int Score => 0;

	public override void Initialize(MVTeam team, int score, GameStatCounterType typeToDisplay)
	{
	}

	public override void Add(MVPlayer player)
	{
	}

	private PlayerElementHoldData CreatePlayerElementHoldData(int score, PlayerElementHold playerElementHold)
	{
		return default;
	}

	private void SortAfterScore(PlayerElementHoldData playerElementHoldData)
	{
	}
}
