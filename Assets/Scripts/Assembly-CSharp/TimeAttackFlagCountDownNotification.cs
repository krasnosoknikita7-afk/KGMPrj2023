using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttackFlagCountDownNotification : Notification
{
	[SerializeField]
	private Text countdownText;

	[SerializeField]
	private NotificationFade countDownFader;

	private float countDownStartTime;

	private const float countDownDuration = 3f;

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
}
