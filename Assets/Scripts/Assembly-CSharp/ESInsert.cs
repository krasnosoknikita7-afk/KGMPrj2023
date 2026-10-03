using System.Collections.Generic;
using UnityEngine;

internal class ESInsert : ESStateBase
{
	private const float returnSpeed = 5f;

	private const float moveSpeed = 20f;

	private const float offsetLerpSpeed = 10f;

	private float distanceInFreeSpace;

	private const float minimumDistance = 5f;

	private Vector3 insertPosition;

	private Vector3 insertOffset;

	private Vector3 pivotToOrigin;

	private InsertCursor insertCursor;

	private Material previewMaterial;

	private MeshFilter[] previewMeshes;

	private bool isNewPrototype;

	private HashSet<int> woIgnoreList;

	private bool pointerWasUp;

	private Camera mainCamera;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}

	private Vector3 ComputeObjectOffset(MVWorldObjectClient wo, Vector3 surfaceNormal)
	{
		return default;
	}

	private bool DrawPlanePick(MVWorldObjectClient wo, ref Vector3 position, ref Vector3 rawPosition, ref Vector3 normal)
	{
		return false;
	}

	private bool WorldPick(MVWorldObjectClient wo, ref Vector3 position, ref Vector3 rawPosition, ref Vector3 normal)
	{
		return false;
	}

	private Vector3 ComputeSnapPosition(MVWorldObjectClient wo, Vector3 originalPos)
	{
		return default;
	}

	private void DrawObject(GameObject go)
	{
	}
}
