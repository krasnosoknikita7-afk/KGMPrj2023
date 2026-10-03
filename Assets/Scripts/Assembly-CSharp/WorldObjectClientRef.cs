public class WorldObjectClientRef<T> where T : MVWorldObjectClient
{
	private readonly int woId;

	public T WorldObjectClient => null;

	protected WorldObjectClientRef(int woId)
	{
	}
}
public class WorldObjectClientRef : WorldObjectClientRef<MVWorldObjectClient>
{
	protected WorldObjectClientRef(int woId)
		: base(0)
	{
	}
}
