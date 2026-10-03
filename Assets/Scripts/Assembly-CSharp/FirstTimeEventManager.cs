using System;
using MV.Common;
using MV.WorldObject.MetaData;

public static class FirstTimeEventManager
{
	private static Action<FirstTimeState, FirstTimeEvent> firstTimeStatePublisher;

	private static FirstTimeState firstTimeState;

	public static Action XPRewarded;

	public static bool FirstTimeSystemInitialized { get; private set; }

	public static bool GetProfileMetaDataOk { get; set; }

	public static void Initialize(FirstTimeState firstTimeState)
	{
	}

	public static void Destroy()
	{
	}

	public static void SubscribeToFirstTimeState(Action<FirstTimeState, FirstTimeEvent> firstTimeStateReceiver)
	{
	}

	public static void UnSubscribeToFirstTimeState(Action<FirstTimeState, FirstTimeEvent> firstTimeStateReceiver)
	{
	}

	public static void SetFirstTimeEvent(FirstTimeEvent firstTimeEvent)
	{
	}

	public static void OnFirstTimeEventResponse(FirstTimeEvent firstTimeEvent, XPRewardType xpRewardType)
	{
	}

	public static void OverrideFirstTimeEvent(FirstTimeEvent firstTimeEvent, bool overrideValue)
	{
	}

	public static void ResetFirstTimeEvents(bool overrideValue)
	{
	}

	public static bool HasFirstTimeEventOccured(FirstTimeEvent firstTimeEvent)
	{
		return false;
	}

	private static void OnLevelingInitialized()
	{
	}
}
