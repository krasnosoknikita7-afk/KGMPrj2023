using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowingAdsPopup : MonoBehaviour
{
	[SerializeField]
	private Button button;

	private float startTime;

	private float timeoutTime;

	private Action skipAction;

	private bool previousMuteState;

	public void Initialize(float timeoutTime, Action OnSkipPressed)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void OnSkip()
	{
	}
}
