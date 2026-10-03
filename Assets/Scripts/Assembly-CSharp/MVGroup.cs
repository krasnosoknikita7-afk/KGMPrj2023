using System.Collections.Generic;
using UnityEngine;

public class MVGroup : MVWorldObjectClient
{
	protected Dictionary<int, MVWorldObjectClient> children;

	public List<MVWorldObjectClient> Children => null;

	public MVGroup(Dictionary<object, object> data, GameObject prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public MVGroup(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public MVGroup(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	private void CreateGroup()
	{
	}

	public HashSet<int> GetHierarchyWorldObjectIDs()
	{
		return null;
	}

	private static Bounds ComputeLocalChildBounds(MVWorldObjectClient wo, BoundsContext boundsContext)
	{
		return default;
	}

	public static Bounds ComputeBoundsForWOs(List<MVWorldObjectClient> woList, BoundsContext boundsContext)
	{
		return default;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Select()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	public override void TraverseRecursiveTail(CallBackDelegate callBack)
	{
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public override void Initialize()
	{
	}

	private void SetupTranformation()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public override void PositionChangedNotify()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void PlayModeInitialize()
	{
	}

	public void RemoveChild(int childId)
	{
	}

	public virtual void TransferChild(int id)
	{
	}

	public virtual void AddChild(MVWorldObjectClient child)
	{
	}

	public MVWorldObjectClient GetChild(int woID)
	{
		return null;
	}

	public static bool IsDescendant(int parentId, int leafId)
	{
		return false;
	}

	public static int GetGroupAbove(int currentParent, int leaf, InteractionFlags returnParentIfHasFlags = InteractionFlags.None)
	{
		return 0;
	}

	public static int GetParentBelow(int parentId, int childId)
	{
		return 0;
	}

	public static int GetParentBelow(MVWorldObjectClient parent, MVWorldObjectClient child)
	{
		return 0;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}
}
