using System.Collections.Generic;
using MV.WorldObject;

public abstract class ARepository
{
	public delegate void OnRepositoryChangeDelegate(ARepository repository);

	public delegate void OnWorldObjectTypeExtracted(WorldObjectType worldObjectType, Dictionary<object, object> woData);

	public OnRepositoryChangeDelegate OnRepositoryChange;

	public Dictionary<int, string> PlanetOwnershipTypes;

	public Dictionary<object, object> itemIDToInventorySlotIndex;

	public ARepository()
	{
	}

	public virtual void RemoveItem(int itemId)
	{
	}

	public void SwapItems(int itemId1, int itemId2)
	{
	}

	public void MoveItem(int itemId, int slotIndex)
	{
	}

	public void NotifyRepositoryChange()
	{
	}

	public static KoGaMaPackageClient GetKoGaMaPackageFromItem(MVItem item)
	{
		return null;
	}

	public static void GetWorldObjectTypeFromMVItemData(byte[] data, OnWorldObjectTypeExtracted onWorldObjectExtracted)
	{
	}
}
