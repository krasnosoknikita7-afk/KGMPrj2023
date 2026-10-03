using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.WorldObject;
using UnityEngine;

public class MVCubeModelBase : MVWorldObjectClient, ICubeModel, ICubeModelCollider
{
	protected RuntimePrototypeCubeModel prototypeCubeModel;

	protected ChunkInstances chunkInstances;

	private bool beingEdited;

	private Queue<CubeModelChangedEventArgs> changedEventArgsQueue;

	public Action<CubeModelChangedEventArgs> Changed;

	public Action<HashSet<IntVector>> ChunksChanged;

	[CompilerGenerated]
	private EventHandler<EditStateEventArgs> m_BeingEditedChanged;

	public ChunkInstances ChunkInstances => null;

	public RuntimePrototypeCubeModel PrototypeCubeModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Pid => 0;

	public Func<IModelingConstraint> ModelingConstraintBuilder { get; set; }

	public bool BeingEdited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ContainsCubes => false;

	public int CubeCount => 0;

	public float PrototypeScale => 0f;

	public MeshFilter[] MeshFilters => null;

	public override Vector3 WorldPivot => default;

	int ICubeModelCollider.Id => 0;

	public event EventHandler<EditStateEventArgs> BeingEditedChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public MVCubeModelBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void HandleDelta()
	{
	}

	public CubeBase GetCubeBase(IntVector pos)
	{
		return null;
	}

	public Cube GetCube(IntVector pos)
	{
		return null;
	}

	public bool ContainsCube(IntVector pos)
	{
		return false;
	}

	private void MakeUnique()
	{
	}

	private bool HasInstances()
	{
		return false;
	}

	public void RemoveCube(IntVector pos)
	{
	}

	public void AddCube(IntVector pos, CubeBase cube)
	{
	}

	public void SetMaterial(IntVector iVector, Face face, byte material)
	{
	}

	public void ReplaceCube(IntVector iVector, byte materialId)
	{
	}

	public void CornersChangedDone(IntVector iVector, Cube cube)
	{
	}

	public void CornersChanged(IntVector iVector, Cube cube)
	{
	}

	public void UnIndentCubeFace(IntVector localPos, Face face, Cube cube)
	{
	}

	public virtual void RemoveCubeNetworkUpdate(IntVector pos)
	{
	}

	public virtual void AddCubeNetworkUpdate(IntVector pos, CubeBase cube)
	{
	}

	public void CubePosToChunkPos(ref IntVector pos)
	{
	}

	public Bounds GetWorldBounds()
	{
		return default;
	}

	public Bounds GetBounds()
	{
		return default;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public Vector3 GetWorldCenterPos()
	{
		return default;
	}

	public override void OnObjectLinkChanged()
	{
	}

	public void ObjectLinkChanged(bool visible)
	{
	}

	protected virtual void DirtyChunksRegeneratedHandler(HashSet<IntVector> chunksChanged)
	{
	}

	public override void Destroy()
	{
	}

	public void UpdatePrototypeScale(float scale)
	{
	}
}
