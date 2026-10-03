using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPNotification : Notification
{
	[SerializeField]
	private Text AmountLabel;

	[SerializeField]
	private NotificationSlideOut slider;

	[SerializeField]
	private GameObject boostedNotification;

	[SerializeField]
	private GameObject defaultNotification;

	[SerializeField]
	private XPNotificationBoostedBehaviour boostedBehaviour;

	private const float boostedXpNotificationLifeTime = 5f;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}
}
