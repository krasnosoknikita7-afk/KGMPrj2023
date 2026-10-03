using System.Collections.Generic;

public class TransformNetworkManager
{
	private Dictionary<int, MVNetworkObject> networkedObjects;

	private List<int> removeList;

	public const int broadcastInterval = 200;

	public const int clientDelay = 200;

	public static int DelayedTime { get; private set; }

	public void RemoveNetworkObject(int woID)
	{
	}

	public void AddReporter(int woID, MVNetworkReporter networkReporter)
	{
	}

	public MVNetworkObject GetNetworkObject(int woID)
	{
		return null;
	}

	public void AddTransformPackage(int woID, NetworkTransformPackage p)
	{
	}

	public void Update(MVNetworkGame game)
	{
	}
}
