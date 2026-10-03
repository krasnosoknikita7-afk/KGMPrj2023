using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public abstract class Notification : MonoBehaviour
{
	public NotificationType Type;

	[HideInInspector]
	public NotificationObjectPool pool;

	protected float timeSinceStart;

	protected abstract NotificationLifetime Lifetime { get; }

	public float Progress => 0f;

	public virtual void Initialize(Dictionary<object, object> data)
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void OnReturn()
	{
	}

	protected void Close()
	{
	}
}
