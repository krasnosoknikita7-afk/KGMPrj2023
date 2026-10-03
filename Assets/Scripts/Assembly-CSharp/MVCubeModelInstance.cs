using System.Collections.Generic;
using IngameController.MVEditor;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.Events;

public class MVCubeModelInstance : MVCubeModelBase
{
	protected CullingSubscriberBase cullingSubscriberBase;

	private bool isVisible;

	private Vector3 positionOffset;

	private TransformGizmo transformGizmo;

	public bool IsVisibleSet
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public MVCubeModelInstance(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public void SetCullDistanceBand(int distanceBandIndex)
	{
	}

	public void EnableCulling()
	{
	}

	public void SetupCulling(UnityAction<CullingGroupEvent> onStateChanged)
	{
	}

	private void OnRotationChanged(MVWorldObjectClient wo, RotationChangedEventArgs rotationChangedEventArgs)
	{
	}

	private void OnChanged(HashSet<IntVector> chunks)
	{
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void SetCullSphereToMeshBounds()
	{
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}

	public override void Compare(MVWorldObjectClient wo, bool visibleCubesOnly, ref int matchingCubeCount, ref int investigatedCubeCount)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public bool IsLodVisible(CullingGroupEvent cullingGroupEvent)
	{
		return false;
	}

	public void ChangeLODVisible()
	{
	}

	private void SetLod(bool enabled)
	{
	}

	public override void Destroy()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void AddSelectionBox()
	{
	}

	public override void AddPreviewBox()
	{
	}

	public Vector3[] GetCorners(Bounds bounds)
	{
		return null;
	}

	public override void DeSelect()
	{
	}

	public override void OnContextMenu()
	{
	}

	public ChunkInstances.ChunkInstanceVariables GetChunkInstance(IntVector chunkPos)
	{
		return default;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override void DrawTransformGizmo()
	{
	}
}
