using System.Collections.Generic;
using MV.Common;

public class NotificationAreaQueue : NotificationArea
{
	private class EnqueuedNotification
	{
		public readonly NotificationType notificationType;

		public readonly Dictionary<object, object> data;

		public EnqueuedNotification(NotificationType notificationType, Dictionary<object, object> data)
		{
		}
	}

	private Queue<EnqueuedNotification> enqueuedNotifications;

	private void Awake()
	{
	}

	private void OnActiveInstancesChanged()
	{
	}

	public override void InstantiateNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	private void CreateNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	private void OnDestroy()
	{
	}
}
