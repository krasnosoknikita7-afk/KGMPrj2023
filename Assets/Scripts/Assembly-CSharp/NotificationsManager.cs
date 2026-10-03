using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class NotificationsManager : MonoBehaviour
{
	[SerializeField]
	private NotificationArea[] notificationAreas;

	private static NotificationsManager _activeInstance;

	public static NotificationsManager ActiveInstance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool Initialized { get; private set; }

	protected void OnEnable()
	{
	}

	protected void OnDestroy()
	{
	}

	public void InstantiateNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}
}
