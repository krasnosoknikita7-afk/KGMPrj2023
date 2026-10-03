using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttackFlagDebriefingNotification : Notification
{
	[SerializeField]
	private Text timeText;

	[SerializeField]
	private Text descriptionText;

	[SerializeField]
	private NotificationFade debriefingFader;

	[SerializeField]
	private Text countdownText;

	[SerializeField]
	private NotificationFade countDownFader;

	private float countDownStartTime;

	private const float countDownDuration = 3f;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}

	private void OnTimeFlagDebriefingEnd()
	{
	}

	private void StartCountDown()
	{
	}

	private void DestroyNotification()
	{
	}
}
