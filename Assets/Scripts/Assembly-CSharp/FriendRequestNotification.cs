using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendRequestNotification : Notification
{
	[SerializeField]
	private Text label;

	private int friendId;

	private const int latestFriendId = -1;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void AcceptFriendship()
	{
	}

	public override void OnReturn()
	{
	}

	private bool ValidateFriendRequest()
	{
		return false;
	}

	protected override void Update()
	{
	}
}
