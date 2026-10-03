using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class RareRewardNotification : Notification
{
	[SerializeField]
	private GameObject EpicPanel;

	[SerializeField]
	private GameObject LegendaryPanel;

	[SerializeField]
	private Text text;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private string TypeToText(RewardType type)
	{
		return null;
	}
}
