using UnityEngine;

public abstract class FirstTimeActivatableMessage : FirstTimeActivatableElementBase
{
	[SerializeField]
	private FirstTimeEventMessage firstTimeEventMessagePrefab;

	[SerializeField]
	private Transform firstTimeMessageParentTransform;

	protected FirstTimeEventMessage firstTimeEventMessage;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	public void FadeOut()
	{
	}

	public void DoDisabled()
	{
	}

	private void OnFinished(GameObject firstTimeEventMessage)
	{
	}

	protected void DestroyMessage()
	{
	}
}
