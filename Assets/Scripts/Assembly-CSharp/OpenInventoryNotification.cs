using System.Collections.Generic;
using UnityEngine;

public class OpenInventoryNotification : Notification
{
	[SerializeField]
	private NotificationFade fader;

	private NotificationLifetime lifeTime;

	private int category;

	private int slot;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	public void NotificationClicked()
	{
	}
}
