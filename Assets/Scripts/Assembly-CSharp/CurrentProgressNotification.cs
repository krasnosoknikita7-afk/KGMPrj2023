using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentProgressNotification : Notification
{
	[Serializable]
	private class WinninConditionImage
	{
		[SerializeField]
		public GameStatCounterType Key;

		[SerializeField]
		public Image Value;
	}

	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Text warningText;

	[SerializeField]
	private Text currentProgressText;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private List<WinninConditionImage> winningConditionImages;

	private int avatarStartTime;

	private bool shouldShowCurrentTime;

	private GameStatCounterType currentDisplayedStatType;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void SelectWinningConditionImage(GameStatCounterType winningConditionType, MVPlayer player)
	{
	}

	private void SetWarningText(GameStatCounterType winningConditionType, int scoreLeft)
	{
	}

	private void DestroyNotification()
	{
	}

	protected override void Update()
	{
	}

	private int GetStartTime()
	{
		return 0;
	}

	private int CalculateCurrentTime(int startTime)
	{
		return 0;
	}

	private static int GetScoreLeftToWin(GameStatCounterType counterType, int scoreCount)
	{
		return 0;
	}

	private int ConvertSecondsToMilliSeconds(float seconds)
	{
		return 0;
	}
}
