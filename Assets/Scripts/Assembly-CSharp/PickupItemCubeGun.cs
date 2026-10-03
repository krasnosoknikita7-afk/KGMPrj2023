using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class PickupItemCubeGun : PickupItemWithDelay
{
	[SerializeField]
	private float minDistanceToCubeFire;

	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float range;

	[SerializeField]
	private Transform chargeObject;

	[SerializeField]
	private ObscuredFloat fireIntervalSecondary;

	[SerializeField]
	private GUICellCursor primaryCursor;

	[SerializeField]
	private GUICellCursor secondaryCursor;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private CubeBullet cubeBullet;

	private float prevFireTime;

	private byte material;

	private bool waitingToFire;

	private ObscuredInt currentAmmo;

	private bool fireMain;

	private bool fireSecondary;

	private bool showingCursors;

	private bool hasLeftVehicle;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	protected override bool IsAmmoDepleted => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public override void OnEquip()
	{
	}

	private bool DoLineOfFireCheck(out VoxelHit hit)
	{
		hit = default;
		return false;
	}

	public override void OnLeaveVehicleWithWeapon()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}

	protected override void OnHolstered()
	{
	}

	protected override void OnUnholstered()
	{
	}

	private bool CanInsertCubeAtCubePos(IntVector cubePos)
	{
		return false;
	}

	private void HandleCursors()
	{
	}

	public override void OnUnequip()
	{
	}

	public override void ResetAmmo()
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	private void SetCubeBulletMaterial(byte materialId)
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	protected void OnFireSecondary(bool isLocal)
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	public override void TriggerEnd()
	{
	}

	private void StartFire()
	{
	}

	private bool ShowCursors()
	{
		return false;
	}

	public override void UpdateControllerUpdate()
	{
	}

	private void DoAutoFire()
	{
	}

	private void Execute()
	{
	}

	private static bool GetCubePosFromFineGrainedTerrain(VoxelHit voxelHit, float maxDistanceToEdge, ref IntVector pos)
	{
		return false;
	}

	public static IntVector GetCubePos(VoxelHit voxelHit)
	{
		return default;
	}
}
