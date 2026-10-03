using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurryUpNotification : Notification
{
	[SerializeField]
	private Text timeText;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private NotificationFade countdownFader;

	[SerializeField]
	private AudioSource countDownSound;

	private int timeStamp;

	private int timeLeftFromTimeStamp;

	private int previousSecondCount;

	private const int mininumMillieSecondDelayBeforePlayingSound = 900;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}

	private void DestroyNotification()
	{
	}

	private void OnRoundEnd(IWinningCondition winningCondition)
	{
	}

	private void OnDestroy()
	{
	}
}
