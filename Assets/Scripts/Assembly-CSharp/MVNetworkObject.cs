public abstract class MVNetworkObject
{
	protected MVWorldObjectClient worldObject;

	public abstract bool RemoveFromUpdate { get; }

	public MVWorldObjectClient WorldObject => null;

	public MVNetworkObject(MVWorldObjectClient owner)
	{
	}

	public abstract void Update(MVNetworkGame game);
}
