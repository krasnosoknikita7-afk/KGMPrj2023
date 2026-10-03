using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class NotificationArea : MonoBehaviour
{
	[SerializeField]
	protected NotificationObjectPool objectPool;

	[SerializeField]
	protected RectTransform contentHolderTransform;

	public virtual void InstantiateNotification(NotificationType notificationType, Dictionary<object, object> data)
	{
	}

	public bool CanInstantiateNotificationType(NotificationType notificationType)
	{
		return false;
	}
}
