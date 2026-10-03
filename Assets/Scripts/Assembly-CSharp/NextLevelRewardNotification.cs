using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelRewardNotification : Notification
{
	[SerializeField]
	private Text goldAmount;

	[SerializeField]
	private Text levelText;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
