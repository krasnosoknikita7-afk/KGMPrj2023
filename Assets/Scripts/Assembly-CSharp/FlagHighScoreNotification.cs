using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagHighScoreNotification : Notification
{
	[SerializeField]
	private Text timeText;

	[SerializeField]
	private Text userNameText;

	[SerializeField]
	private NotificationFade fader;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void DestroyNotification()
	{
	}
}
