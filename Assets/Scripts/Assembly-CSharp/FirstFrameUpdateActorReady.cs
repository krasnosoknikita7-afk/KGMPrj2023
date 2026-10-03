using System;

public class FirstFrameUpdateActorReady : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	private bool localPlayerIsReady;

	private bool firstFrameCallbackDone;

	public Action callbacks;

	private void OnLocalPlayerReady()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}
}
