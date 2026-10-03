using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public abstract class MVWorldObjectClientManager : IWorldObjectManager
{
	protected class WorldObjectMapping
	{
		private readonly Dictionary<WorldObjectType, HashSet<int>> worldObjectTypeSets;

		private readonly Dictionary<int, int> gameObjectIdToWorldObjectIdMap;

		private readonly Dictionary<Type, WorldObjectType> typeWorldObjectTypeMap;

		public void AddWorldObjectToTypeSet(MVWorldObjectClient wo)
		{
		}

		public HashSet<int> GetWorldObjectTypeSet(WorldObjectType worldObjectType)
		{
			return null;
		}

		public void RemoveWorldObjectFromTypeSet(MVWorldObjectClient wo)
		{
		}

		public bool TryGetWorldObjectTypeFromObjectType(Type type, ref WorldObjectType worldObjectType)
		{
			return false;
		}

		public bool TryGetWorldObjectIDFromGameObjectID(int goId, out int woID)
		{
			woID = default;
			return false;
		}

		private void AddToGameObjectIDMap(MVWorldObjectClient wo)
		{
		}

		private void AddWorldObjectToTypeWorldObjectTypeMap(Type type, WorldObjectType worldObjectType)
		{
		}

		private void RemoveWorldObjectFromTypeWorldObjectTypeMap(Type type)
		{
		}
	}

	private class WOCMWorldObjectClientRef<T> : WorldObjectClientRef<T> where T : MVWorldObjectClient
	{
		public WOCMWorldObjectClientRef(int woId)
			: base(0)
		{
		}
	}

	private class WOCMWorldObjectClientRef : WorldObjectClientRef
	{
		public WOCMWorldObjectClientRef(int woId)
			: base(0)
		{
		}
	}

	protected readonly Dictionary<int, MVWorldObjectClient> worldObjects;

	protected readonly Queue<int> pendingUngroupQueue;

	protected readonly WorldObjectMapping worldObjectMapping;

	protected Dictionary<int, Action<object, WorldObjectDestroyedEventArgs>> woDestroyedEventSubscribers;

	protected Dictionary<Type, Action<object, WorldObjectCreatedEventArgs>> woCreatedEventSubscribers;

	private int rootGroupId;

	private Bounds worldBounds;

	public EventHandler<OnTransferOwnershipResponseEventArgs> OnWorldObjectTransferOwnershipResponse;

	public EventHandler<OnHierarchyLockedEventArgs> OnHierarchyLockedResponse;

	public EventHandler<OnTransferWosResponseEventArgs> OnTransferWosResponse;

	public EventHandler<CloneWorldObjectTreeResponseEventArgs> CloneWorldObjectTreeResponse;

	public EventHandler<EventArgs> OnResetWorldDone;

	public MoveableController MoveableController { get; private set; }

	public Bounds WorldBounds => default;

	public int Count => 0;

	public MVGroup RootGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MVWorldObjectClientManager()
	{
	}

	public bool Contains(int woID)
	{
		return false;
	}

	public bool IsType(int woID, WorldObjectType worldObjectType)
	{
		return false;
	}

	public void GetAllWoIds(int id, HashSet<int> ids)
	{
	}

	public void UpdateWorldBounds(Bounds bounds)
	{
	}

	public List<MVWorldObjectClient> GetWorldObjectsByType(WorldObjectType type)
	{
		return null;
	}

	public int GetWoIDHighestInHierarchyWithComponent<T>(int woId) where T : Component
	{
		return 0;
	}

	public T GetSingletonWorldObject<T>() where T : MVWorldObjectClient
	{
		return null;
	}

	public WorldObjectClientRef<T> GetSingletonWorldObjectRef<T>() where T : MVWorldObjectClient
	{
		return null;
	}

	private MVWorldObjectClient GetSingletonWorldObjectByType(WorldObjectType worldObjectType)
	{
		return null;
	}

	public static T GetEnabledMonoBehaviourHighestInHierarchy<T>(GameObject gameObject) where T : MonoBehaviour
	{
		return null;
	}

	public int GetWoIDWithLocalOwnerHighestInHierarchy(int woID)
	{
		return 0;
	}

	public List<MVWorldObjectClient> GetBlueprintWorldObjectsByType(Type type)
	{
		return null;
	}

	public bool GetUnmodifiedWorldObject(KoGaMaPackageClient koGaMaPackageClient, ref int worldObjectId)
	{
		return false;
	}

	public MVWorldObjectClient GetWorldObjectClient(int id)
	{
		return null;
	}

	public T GetWorldObjectClient<T>(int id) where T : MVWorldObjectClient
	{
		return null;
	}

	public WorldObjectClientRef<T> GetWorldObjectClientRef<T>(int id) where T : MVWorldObjectClient
	{
		return null;
	}

	public static WorldObjectClientRef<MVWorldObjectClient> GetWorldObjectClientRefNullRefTyped()
	{
		return null;
	}

	public WorldObjectClientRef GetWorldObjectClientRef(int id)
	{
		return null;
	}

	public static WorldObjectClientRef GetWorldObjectClientRefNullRef()
	{
		return null;
	}

	public MVWorldObject GetWorldObject(int id)
	{
		return null;
	}

	public bool TryGetWorldObject(int id, out MVWorldObject worldObject)
	{
		worldObject = null;
		return false;
	}

	public MVWorldObjectClient GetWorldObjectClientRoot(int id)
	{
		return null;
	}

	public MVWorldObjectClient GetWorldObjectClientWhere(Func<MVWorldObjectClient, bool> predicate)
	{
		return null;
	}

	public IEnumerable<MVWorldObjectClient> GetWorldObjectClientsWhere(Func<MVWorldObjectClient, bool> predicate)
	{
		return null;
	}

	public MVWorldObjectClient GetWorldObjectByGoId(int goId)
	{
		return null;
	}

	public static MVWorldObjectClient GetMVObject(Transform t)
	{
		return null;
	}

	public static MVWorldObjectClient GetValidSpawnPoint()
	{
		return null;
	}

	private WorldObjectType GetSpawnPointTypeForNoneTeam()
	{
		return WorldObjectType.PlayModeAvatar;
	}

	public void SubscribeWODestroyedEvent(int woID, Action<object, WorldObjectDestroyedEventArgs> woDestroyedEventHandler)
	{
	}

	public void UnsubscribeWODestroyedEvent(int woID, Action<object, WorldObjectDestroyedEventArgs> woDestroyedEventHandler)
	{
	}

	public void SubscribeWOCreatedEvent(Type type, Action<object, WorldObjectCreatedEventArgs> woCreatedEventHandler)
	{
	}

	public void UnsubscribeWOCreatedEvent(Type type, Action<object, WorldObjectCreatedEventArgs> woCreatedEventHandler)
	{
	}

	public bool UnregisterWorldObject(int worldObjectId)
	{
		return false;
	}

	public void CloneWorldObjectTree(MVWorldObjectClient root, bool localOwner, bool setAsPreviewItem, bool cloneToRootGroup)
	{
	}
}
