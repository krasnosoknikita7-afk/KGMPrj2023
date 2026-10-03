public class TabState
{
	private readonly int slotsPrPage;

	public readonly string name;

	public int highestSlotIndex;

	public int currentPage;

	public int MaxPages => 0;

	public int[] SlotRange => null;

	public int TabID { get; private set; }

	public TabState(int tabId, string name, int slotsPrPage)
	{
	}

	public bool UpdatePage(int pageDir)
	{
		return false;
	}

	public bool SetPage(int page)
	{
		return false;
	}

	public bool SlotIndexIsInRange(int slotIndex)
	{
		return false;
	}
}
