using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatableMessagePopup : FirstTimeActivatableElementBase
{
	private float showedTime;

	private bool isShown;

	private bool isDone;

	[SerializeField]
	private string messageText;

	[SerializeField]
	private FirstTimeEventMessage firstTimeEventMessagePrefab;

	[SerializeField]
	private List<UIPushOption> pushOptions;

	[SerializeField]
	private float stayTimeInSeconds;

	protected FirstTimeEventMessage firstTimeEventMessage;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	private void PushToStack()
	{
	}

	private void OnFinished(GameObject firstTimeEventMessage)
	{
	}

	private void OnPop()
	{
	}

	public void FadeOut()
	{
	}

	private void Update()
	{
	}
}
