using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningWarningNotification : Notification
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
	private Text userNameText;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private List<WinninConditionImage> winningConditionImages;

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
}
