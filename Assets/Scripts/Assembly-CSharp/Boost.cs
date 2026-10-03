public class Boost
{
	private string description;

	public BoostType Type { get; private set; }

	public object Value => null;

	public string BoostKey { get; private set; }

	public string Description
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string ValueDescription { get; private set; }

	public string EditTitle { get; private set; }

	public bool AllowedForGame { get; set; }

	public Boost(BoostType type, string boostKey, string desc, string valueDesc, string title, bool allowedForGame)
	{
	}
}
