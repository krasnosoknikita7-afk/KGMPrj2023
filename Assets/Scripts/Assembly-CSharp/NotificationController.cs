using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class NotificationController : MonoBehaviour
{
	private static HashSet<int> incomingPlayerFriendRequests;

	private static NotificationsManager NotificationsManager => null;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public static void OnNotificationReceived(NotificationType type, Dictionary<object, object> data)
	{
	}

	private static void FriendRequestAccepted(Dictionary<object, object> data)
	{
	}

	private static void ReceivedFriendsRequest(Dictionary<object, object> data)
	{
	}

	public static void PushNotification(string text, Sprite sprite = null, int lifeTime = 5)
	{
	}

	public static void PushNotification(NotificationType notificationType, NotificationLifetime lifeTime = NotificationLifetime.High)
	{
	}

	public static void PushNotification(NotificationType notificationType, Dictionary<object, object> data, NotificationLifetime lifeTime = NotificationLifetime.High)
	{
	}

	public static void PushNoticationInstruction(string instruction, NotificationLifetime lifeTime = NotificationLifetime.High)
	{
	}
}
