using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;
using UnityEngine;

public class CubeModelingStateMachine : FSMEntity
{
	public delegate void OnCurrentMaterialChangeDelegate(byte currentMaterialId, Material currentMaterial);

	public enum HoverType
	{
		Corner = 0,
		Edge = 1,
		Face = 2,
		None = 3
	}

	private ObscuredByte currentMaterialId;

	private Material currentMaterial;

	private IModelingConstraint constraint;

	public OnCurrentMaterialChangeDelegate OnCurrentMaterialChange;

	public bool useLasers;

	private GameObject gameObject;

	private Camera mainCamera;

	public CubePickingInfo SelectedCube { get; set; }

	public byte CurrentMaterialId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MVCubeModelBase TargetCubeModel { get; private set; }

	public bool CursorVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3[] CubeCorners => null;

	public byte[] ByteCubeCorners => null;

	public Material CurrentMaterial => null;

	public CubeModelingStateMachine(GameObject gameObject)
	{
	}

	public void StartEdit(MVCubeModelBase targetCubeModel, IModelingConstraint constraint = null)
	{
	}

	public void SetConstraint(IModelingConstraint constraint)
	{
	}

	public void EndEdit()
	{
	}

	public override void Update()
	{
	}

	public HoverType CurrentlyHovered()
	{
		return HoverType.Corner;
	}

	public CubePickingInfo DoPicking()
	{
		return null;
	}

	public void RemoveCursors()
	{
	}

	public void HandleAudio(IntVector pos, AudioActions action)
	{
	}

	public EditCubeChange AddCube()
	{
		return EditCubeChange.None;
	}

	public CanPerformCubeActionResult CanAddCubeAt(IntVector requestedCubePos, CubePickingInfo requestedCube)
	{
		return CanPerformCubeActionResult.Yes;
	}

	public CanPerformCubeActionResult CanAddCubeAt(IntVector requestedCubePos)
	{
		return CanPerformCubeActionResult.Yes;
	}

	public CanPerformCubeActionResult CanRemoveCubeAt(CubePickingInfo requestedCube)
	{
		return CanPerformCubeActionResult.Yes;
	}

	public bool CanEditCubeAt(IntVector requestedCubePos)
	{
		return false;
	}

	public CanPerformCubeActionResult CanReplaceCube(CubePickingInfo requestedCube, byte materialId)
	{
		return CanPerformCubeActionResult.Yes;
	}
}
