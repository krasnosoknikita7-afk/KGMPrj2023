using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class NotificationObjectPool : MonoBehaviour
{
	[SerializeField]
	private List<NotificationObjectPoolElement> Elements;

	private List<Notification> Instances;

	private List<Notification> ActiveInstances;

	public Action OnActiveInstancesChanged;

	public int ActivateInstancesCount => 0;

	public bool CanInstantiateNotificationType(NotificationType notificationType)
	{
		return false;
	}

	private void Awake()
	{
	}

	public void ReturnAllExistingNotifications()
	{
	}

	public Notification GetPanel(NotificationType type)
	{
		return null;
	}

	public void Return(Notification notification)
	{
	}

	private Notification CreateTempPanel(NotificationType type)
	{
		return null;
	}

	private void AddToActiveInstances(Notification notification)
	{
	}

	private void RemoveFromActiveInstances(Notification notification)
	{
	}
}
