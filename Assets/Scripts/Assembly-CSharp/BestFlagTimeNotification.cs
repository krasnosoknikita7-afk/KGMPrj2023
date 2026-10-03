using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestFlagTimeNotification : Notification
{
	[SerializeField]
	private Text timeText;

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
