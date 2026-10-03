using System.Collections.Generic;
using UnityEngine;

public class EditorStateMachine : FSMEntity
{
	private SelectionController selectionController;

	private MainCameraManager weCamera;

	private CubeModelingStateMachine cubeModelingStateMachine;

	private MVNetworkSelector networkSelector;

	private GameObject gameObject;

	public const float sqrEpsilon = 0.64f;

	public MVNetworkSelector NetworkSelector => null;

	public MainCameraManager MainCameraManager => null;

	public bool GridMode { get; set; }

	public CubeModelingStateMachine CubeModelingStateMachine => null;

	public EditorEvent CurEvent => EditorEvent.EditCubes;

	public EditorEvent PrevEvent => EditorEvent.EditCubes;

	public EditorEvent NextEvent => EditorEvent.EditCubes;

	public ISelectionController SelectionController => null;

	public HashSet<int> SelectedIDs => null;

	public HashSet<MVWorldObjectClient> SelectedWOs => null;

	public MVWorldObjectClient SingleSelectedWO => null;

	public int ParentGroupID => 0;

	public MVGroup ParentGroup => null;

	public bool ParentGroupIsRoot => false;

	public GameObject GameObject => null;

	private EditorStateMachine(GameObject gameObject)
	{
	}

	public EditorStateMachine(GameObject gameObject, Vector3 avatarEditModeCenterPos)
	{
	}

	public EditorStateMachine(GameObject gameObject, ContextMenuController contextMenuController, GizmoController gizmoController)
	{
	}

	public void EnterGroup(MVGroup group)
	{
	}

	public int ExitGroup()
	{
		return 0;
	}

	public int ExitGroupToRoot()
	{
		return 0;
	}

	public WorldObjectClientRef Select(bool addToSelection, int layerMask = -5)
	{
		return null;
	}

	public WorldObjectClientRef Select(VoxelHit hit, bool addToSelection)
	{
		return null;
	}

	public void DeSelectWorldObject(MVWorldObjectClient wo)
	{
	}

	public WorldObjectClientRef SelectWO(int id, bool addToSelection, bool showVisuals = true)
	{
		return null;
	}

	public void DeSelectAll()
	{
	}

	public void DeSelectAllExcept(int id)
	{
	}

	public bool IsSelected(int id)
	{
		return false;
	}

	public override void Update()
	{
	}
}
