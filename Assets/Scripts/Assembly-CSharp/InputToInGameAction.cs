public class InputToInGameAction
{
	private bool use;

	private bool fire;

	private bool drop;

	private bool holster;

	private bool ignorePickupOwner;

	public bool IgnorePickupOwner
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Fire
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Drop => false;

	public bool Use => false;

	public bool Holster => false;

	public void HandleInputState()
	{
	}
}
