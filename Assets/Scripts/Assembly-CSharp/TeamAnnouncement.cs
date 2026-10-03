using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamAnnouncement : Notification
{
	[SerializeField]
	private Text teamColorText;

	[SerializeField]
	private NotificationFade fader;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
