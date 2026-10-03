using System.Collections.Generic;

public class MVWorldObjectClientManagerNetwork : MVWorldObjectClientManager
{
	public void Cleanup()
	{
	}

	public void OnCloneWorldObjectTreeResponse(bool success, int rootId)
	{
	}

	public void ResetWorld()
	{
	}

	public void ResetLocalWorldObject()
	{
	}

	public bool OnSetWorldObjectsToPurchasedEvent(int profileID, int itemID)
	{
		return false;
	}

	public void OnTransferWorldObjectsToGroupEvent(int groupId, int[] worldObjectsToGroup)
	{
	}

	public void OnUpdateWorldObjectDataEvent(int worldObjectID, Dictionary<object, object> worldObjectData)
	{
	}

	public void OnUpdateWorldObjectDataPartialEvent(int worldObjectID, Dictionary<object, object> worldObjectData)
	{
	}

	public void OnRemoveWorldObjectDataPartialEvent(int worldObjectID, Dictionary<object, object> worldObjectDataToRemove)
	{
	}

	public void OnUpdateWorldObjectRunTimeDataEvent(int worldObjectID, Dictionary<object, object> delta)
	{
	}

	public bool TransferOwnershipProxy(int id, int ownerActorNr)
	{
		return false;
	}

	public void HandleTransferWorldObjectsToGroup(bool success)
	{
	}

	public bool TransferOwnershipResponse(int id, int ownerActorNr, bool success)
	{
		return false;
	}

	public bool LockHierarchyResponse(int id, bool lockObject, bool success)
	{
		return false;
	}

	public bool LockHierarchyProxy(int id, int actorNr)
	{
		return false;
	}

	private void SetOwnerInHierarchy(int id, int actorNr)
	{
	}

	public void DestroyWO(int id)
	{
	}

	private void DeleteWO(int id)
	{
	}

	public void OnWorldObjectDestroyed(int woID)
	{
	}

	public void OnAttachWorldObjectToSeat(int instigatorActorNr, int seatOwnerWoID, int worldObjectID, int seatID)
	{
	}

	public void AddToWorldObjects(MVWorldObjectClient wo)
	{
	}

	public bool Ungroup(int id)
	{
		return false;
	}

	public MVWorldObjectClient Clone(int ownerActorNumber, MVWorldObjectClient rootOriginal, CloneBookkeeping cloneBookkeeping, MVWorldInventory worldInventory)
	{
		return null;
	}

	public void AddWorldObject(Dictionary<object, object> data, MVWorldInventory worldInventory)
	{
	}
}
