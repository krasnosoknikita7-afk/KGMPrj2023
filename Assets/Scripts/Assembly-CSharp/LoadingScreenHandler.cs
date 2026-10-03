using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenHandler : MonoBehaviour
{
	[SerializeField]
	private ProgressBarAndroid loadingBar;

	[SerializeField]
	private Text uiText;

	private Dictionary<MVGameMode, int> eventCountLookup;

	private int currentEventCount;

	private int eventsCount;

	private const float lerpSpeed = 1f;

	private float currentProgress;

	private float targetProgress;

	private float currentTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGameMessageReceived(MVGameMsgType gameMsgType, Dictionary<object, object> gameMsgData)
	{
	}

	private void OnDestroy()
	{
	}
}
