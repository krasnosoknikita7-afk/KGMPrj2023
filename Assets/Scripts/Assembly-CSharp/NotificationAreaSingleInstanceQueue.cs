using System.Collections.Generic;
using MV.Common;

public class NotificationAreaSingleInstanceQueue : NotificationArea
{
	private struct NotificationQueueData
	{
		public NotificationType notificationType;

		public Dictionary<object, object> data;

		public float startTime;
	}

	private Queue<NotificationQueueData> enqueuedNotifications;

	private bool shouldSkipDequeueCallback;

	private const float decayTime = 10f;

	public override void InstantiateNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	private void Awake()
	{
	}

	private void QueueNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	private void ShowNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	private void OnActiveInstancesChanged()
	{
	}
}
