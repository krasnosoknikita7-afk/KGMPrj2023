using System.Collections.Generic;
using MV.WorldObject;

public class WorldNetwork : World
{
	private Links links;

	private ObjectLinks objectLinks;

	public MVWorldObjectClientManagerNetwork WorldObjectClientManagerNetwork => null;

	public RuntimeEventManagerNetwork RuntimeEventManagerNetwork => null;

	public void Update(MVNetworkGame game)
	{
	}

	public void CreateGameWorldFromQueryData(BytePacker queryData, int instigatorActorNumber)
	{
	}

	private void OnGameDataDeserialized(BytePacker queryData, int instigatorActorNumber, int rootId)
	{
	}

	private void ConstructRuntimeEventManager()
	{
	}

	public void AddGameQueryDataToGameWorld(BytePacker queryData, int instigatorActorNumber)
	{
	}

	private MVWorldObjectClient InitializeQueryData(BytePacker queryData)
	{
		return null;
	}

	private void DeserializeRuntimeEvents(BytePacker queryData)
	{
	}

	private void CreateQueryEvent(MVWorldObjectClient root, int instigatorActorNumber)
	{
	}

	private void HandleDeserializedWorldData(Dictionary<object, object> data, KogamaDataType dataType)
	{
	}

	private void AddPrototype(Dictionary<object, object> data)
	{
	}

	private void AddWorldObject(Dictionary<object, object> data)
	{
	}

	private void AddLink(Dictionary<object, object> data)
	{
	}

	private void AddObjectLink(Dictionary<object, object> data)
	{
	}

	public MVWorldObjectClient OnCloneWorldObjectTreeEvent(int ownerActorNumber, int previewProfileOwnerId, bool cloneToRootGroup, int originalId, int cloneId, int cloneLinkId, int cloneObjectLinkId)
	{
		return null;
	}

	private void CloneLinks(CloneBookkeeping cloneBookkeeping)
	{
	}

	private void CloneObjectLinks(CloneBookkeeping cloneBookkeeping)
	{
	}

	public bool OnUnregisterWorldObject(int id)
	{
		return false;
	}

	public void AddLink(Link link)
	{
	}

	public Link RemoveLink(int linkID)
	{
		return null;
	}

	public bool LinksContains(int linkID)
	{
		return false;
	}

	public void AddObjectLink(ObjectLink objectLink)
	{
	}

	public void RemoveObjectLink(int objectLinkID)
	{
	}

	public bool ObjectLinksContains(int linkID)
	{
		return false;
	}
}
