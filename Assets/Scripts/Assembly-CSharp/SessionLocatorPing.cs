using UnityEngine.Networking;

public class SessionLocatorPing : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	private WaitForTicksLocal waitForTicks;

	private int pingIntervalInMilliSeconds;

	private bool pingInFlight;

	private bool connectionLost;

	public void UpdateControllerUpdate()
	{
	}

	public void BackgroundUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public static void LeaveSession()
	{
	}

	private void InternalUpdate()
	{
	}

	private void WWWCallBack(UnityWebRequest result)
	{
	}

	private void OnPingError(UnityWebRequest result)
	{
	}

	private void CloseApplication()
	{
	}
}
