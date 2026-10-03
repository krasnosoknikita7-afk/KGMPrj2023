using MV.WorldObject;

public class LogicObjectManagerClient : LogicObjectManager
{
	public LogicObjectManagerClient(int timeStamp, bool trackLoops)
		: base(0, trackLoops: false)
	{
	}

	public int OnLinkAdded(Link link, IWorldObjectManager worldObjectManager)
	{
		return 0;
	}

	public int OnLinkRemoved(Link link, IWorldObjectManager worldObjectManager)
	{
		return 0;
	}

	public void Clear()
	{
	}
}
