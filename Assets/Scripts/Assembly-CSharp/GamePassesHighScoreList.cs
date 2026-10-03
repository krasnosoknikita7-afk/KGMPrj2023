using System.Collections.Generic;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesHighScoreList : MonoBehaviour
{
	private enum GamePassesHighScoreListState
	{
		Inactive = 0,
		LoadingLocalPlayerHighScoreList = 1,
		LoadingTopPlayerHighScoreList = 2,
		ShowingLocalPlayerHighScoreList = 3,
		ShowingTopPlayersHighScoreList = 4
	}

	private struct HighScoreListData
	{
		public List<HighScoreEntry> scoreList;

		public int topRank;
	}

	[SerializeField]
	private GamePassesHighScoreElement highScoreElementPrefab;

	[SerializeField]
	private GameObject touristInformationPopup;

	[SerializeField]
	private Transform contentList;

	[SerializeField]
	private GameObject waitForHighScore;

	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Text loadingText;

	[SerializeField]
	private int scoreElementShowCapacity;

	[SerializeField]
	private int middlePosition;

	[SerializeField]
	private float moveAmountPerElement;

	[SerializeField]
	private float topPadding;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private Dictionary<GamePassesHighScoreListState, HighScoreListData> highScoreListDatas;

	private GamePassesHighScoreListState currentState;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetToLocalPlayerHighScore()
	{
	}

	private void LoadLocalPlayerHighScore()
	{
	}

	private void SetToTopPlayerHighScore()
	{
	}

	private void LoadTopPlayerHighScore()
	{
	}

	private void OnHighScoreUpdate(HighScoreDatas newHighScoreData)
	{
	}

	private void LoadDone()
	{
	}

	private void CreateHighScoreListData(HighScoreDatas newHighScoreData)
	{
	}

	private List<HighScoreEntry> SortHighScoreEntry(List<HighScoreEntry> listToSort)
	{
		return null;
	}

	private void CreateHighScoreList()
	{
	}

	private int CalculateRealTopRank(int playerRank, List<HighScoreEntry> highScoresEntries)
	{
		return 0;
	}

	private int GetPlayerPosition(List<HighScoreEntry> highScoresEntries)
	{
		return 0;
	}

	private void HandlePlayerNotCentered()
	{
	}

	private void CreateHighScoreElements(List<HighScoreEntry> listOfScores, int topRank)
	{
	}

	private void ClearHighScoreElements()
	{
	}

	public void Exit()
	{
	}
}
