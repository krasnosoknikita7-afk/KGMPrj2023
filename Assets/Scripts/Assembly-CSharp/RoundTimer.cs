using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class RoundTimer : MonoBehaviour
{
	[SerializeField]
	private Text timeLeftText;

	[SerializeField]
	private ProgressBar progressBar;

	private WorldObjectClientRef<MVRoundCube> roundCube;

	private List<int> timeNotifications;

	public Action<NotificationType, Dictionary<object, object>> OnTimeNotificationSend;

	public void Initialize(WorldObjectClientRef<MVRoundCube> roundCube)
	{
	}

	public void ResetOnRoundEnd()
	{
	}

	private void Update()
	{
	}

	private void HandleTimeNotifications(int timeLeft)
	{
	}

	private void ResetTimeNotifications()
	{
	}

	private void OnDestroy()
	{
	}
}
