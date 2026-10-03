using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class RuntimePrototypeCubeModel
{
	private ILogger logger;

	private HashSet<IntVector> dirtyChunks;

	private MeshGeneratePriority meshGeneratePriority;

	private bool useMeshGeneratePrioritySystem;

	private int chunkSize;

	public Action<IntVector> OnChunkRebuilt;

	public float? PendingScaleUpdate;

	private PrototypeState prototypeState;

	private List<byte> pendingDeltaCubes;

	protected int prototypeId;

	private DeltaCubes deltaCubes;

	private Dictionary<IntVector, CubeModelChunk> chunks;

	private HashSet<int> instances;

	public Action<HashSet<IntVector>> DirtyChunksRegenerated;

	public MeshGeneratePriority MeshGeneratePriority => MeshGeneratePriority.None;

	public int ChunkSize => 0;

	public PrototypeState PrototypeState
	{
		get
		{
			return PrototypeState.Registered;
		}
		set
		{
		}
	}

	public float Scale { get; private set; }

	public int PrototypeId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AuthorProfileID { get; private set; }

	public int InstancesCount => 0;

	public int DeltaCubesCount => 0;

	public DeltaCubes DeltaCubes => null;

	public Dictionary<IntVector, CubeModelChunk> Chunks => null;

	public HashSet<int> Instances => null;

	public int CubeCount => 0;

	public bool ContainsCubes => false;

	private void FineGrainedTerrainOverrideChunkSize(int size)
	{
	}

	private RuntimePrototypeCubeModel()
	{
	}

	public RuntimePrototypeCubeModel(int id, int authorProfileId, float scale, byte[] data)
	{
	}

	public RuntimePrototypeCubeModel(int id, int authorProfileId, float scale, byte[] data, int chunkSize)
	{
	}

	private void Create(int id, int authorProfileId, float scale, byte[] data)
	{
	}

	public RuntimePrototypeCubeModel CloneGeometry(bool withDeltaCubes = false)
	{
		return null;
	}

	public void RemoveAllCubesLocal()
	{
	}

	public bool MeshGenerateDirtyChunksAll(ref int meshUpdates)
	{
		return false;
	}

	public bool MeshGenerateDirtyChunks(ref int meshUpdates)
	{
		return false;
	}

	private bool MeshGenerateStatus(HashSet<IntVector> generatedChunks)
	{
		return false;
	}

	public GameObject GetMesh()
	{
		return null;
	}

	private void SetVisibility()
	{
	}

	public Vector3 GetRandomCubePos(GameObject go)
	{
		return default;
	}

	public Cube GetCube(IntVector cubePos)
	{
		return null;
	}

	public bool AddCube(IntVector pos, Cube cube)
	{
		return false;
	}

	public void UnIndentCubeFace(IntVector localPos, Face face, Cube cube)
	{
	}

	public void SetMaterial(IntVector iVector, Face face, byte materialId)
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

	public bool RemoveCube(IntVector iVector)
	{
		return false;
	}

	public void CreateInstance(MVCubeModelBase cm)
	{
	}

	public void RemoveInstance(int id)
	{
	}

	public void ResetSharedMaterials(MVCubeModelInstance cm)
	{
	}

	private static void DecodeBytePacker(BytePacker bp, RuntimePrototypeCubeModel rpcm)
	{
	}

	public void UpdatePrototype(BytePacker bp)
	{
	}

	public void UpdatePrototypeScale(float scale)
	{
	}

	public void AddCubeNetworkUpdate(IntVector iVector, Cube cube, MeshGeneratePriority priority)
	{
	}

	public void RemoveCubeNetworkUpdate(IntVector iVector, MeshGeneratePriority priority)
	{
	}

	public void HandleDelta()
	{
	}

	private void RebuildChunk(IntVector chunkPos, Vector3 scale)
	{
	}

	private void RebuildPrototypeMesh()
	{
	}

	private void AddChunk(IntVector chunkPos)
	{
	}

	private void RemoveChunk(IntVector chunkPos)
	{
	}

	private void SetInstanceDataRef(IntVector chunkPos, MVCubeModelBase cubeInstance)
	{
	}

	private void CreateFromBytePackage(BytePacker bp)
	{
	}

	private void AddToChunk(IntVector iVector, Cube cube, MeshGeneratePriority meshGeneratePriority, bool setVisibility = true)
	{
	}

	private CubeModelChunk GetChunkFromCubePos(IntVector cubePos)
	{
		return null;
	}

	private void RemoveFromChunk(IntVector iVector, MeshGeneratePriority meshGeneratePriority)
	{
	}

	private void AddToDirtyChunks(IntVector chunkPos, MeshGeneratePriority meshGeneratePriority)
	{
	}

	public static BytePacker GetBytePackerFromCubeDict(Dictionary<IntVector, Cube> cubesDict, bool addCount)
	{
		return null;
	}

	public void CubePosToChunkPos(ref IntVector cubePos)
	{
	}

	public void AddRefenceToChunk(ref IntVector chunkPosition)
	{
	}

	public void RemoveRefenceFromChunk(ref IntVector chunkPosition)
	{
	}

	public int GetRefenceCountFromChunk(ref IntVector chunkPosition)
	{
		return 0;
	}

	public void AddReferenceToAllChunks()
	{
	}

	public void RemoveReferenceFromAllChunks()
	{
	}

	public bool CompareGeometry(RuntimePrototypeCubeModel rpcm)
	{
		return false;
	}

	public void CompareGeometryDetailed(RuntimePrototypeCubeModel rpcm, bool visibleCubesOnly, ref int matchingCubeCount, ref int investigatedCubeCount)
	{
	}

	public void Destroy()
	{
	}
}
