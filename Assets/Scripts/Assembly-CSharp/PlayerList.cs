using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class PlayerList : PlayerListBase
{
	private struct PlayerElementData
	{
		public int score;

		public PlayerElement playerElement;
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

	private List<PlayerElementData> playerElementList;

	[SerializeField]
	private RectTransform contentPanel;

	[SerializeField]
	private PlayerElement playerElementPrefab;

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

	private PlayerElementData CreatePlayerElementHoldData(int score, PlayerElement playerElement)
	{
		return default;
	}

	private void SortAfterScore(PlayerElementData playerElementData)
	{
	}
}
