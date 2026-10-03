using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ScoreBoardBase : MonoBehaviour
{
	[Serializable]
	protected class ScoreData
	{
		public Text ScoreText;

		public Text NameText;

		public Text PlacementText;

		public int Id;

		public int Score;

		public Image Background;

		public GameObject MemberUI;

		public Text MemberPlacementText;

		public bool ShouldShowMemberUI;
	}

	protected GameStatCounterType statType;

	[SerializeField]
	protected List<ScoreData> scoreBoardPlayerData;

	protected float backgroundAlpha;

	public abstract void OnStatsChange(int id, int scoreCount);

	public virtual void Initialize(GameStatCounterType statType)
	{
	}

	public void ChangeStatType(GameStatCounterType statType)
	{
	}

	public virtual void ReSortScoreBoard()
	{
	}

	protected void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}

	protected void SortNewScore(string playerName, int id, int scoreCount, bool activateMemberUI = false)
	{
	}

	private bool HandleAlreadyOnScoreBoard(int id, int newScore)
	{
		return false;
	}

	protected bool IsNewScoreBetter(int newScore, int oldScore)
	{
		return false;
	}

	protected virtual bool IsNewScoreBetter(int newScore, int oldScore, int newId, int oldId)
	{
		return false;
	}

	protected virtual string ScoreIntoString(int score)
	{
		return null;
	}

	protected void OnDestroy()
	{
	}

	protected virtual void UnSubscribeToCallbacks()
	{
	}

	protected virtual Color GetBackgroundColor(int id)
	{
		return default;
	}

	protected abstract void HandleParticipantListChanged();

	private void SetPlacementTextForIndex(int index)
	{
	}

	protected void ResetScoreBoard()
	{
	}

	private void SetActiveMemberUI(int index, bool shouldBeActive)
	{
	}
}
