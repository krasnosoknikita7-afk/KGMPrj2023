using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemMultiThrowingStar : PickupItemWithDelay
{
	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private float bulletRangeStraight;

	[SerializeField]
	private float bulletRangeFall;

	[SerializeField]
	private float bulletFallRate;

	[SerializeField]
	private float bulletSpeed;

	[SerializeField]
	private int numStars;

	[SerializeField]
	private float fireSpacingDelay;

	[SerializeField]
	private float fireRate;

	[SerializeField]
	private AudioSource fireSound;

	private static readonly float baseDamage;

	private ObscuredInt currentAmmo;

	private int throwingStarsFired;

	private float fireTime;

	private bool isLocal;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	protected override bool IsAmmoDepleted => false;

	private void Awake()
	{
	}

	public override void ResetAmmo()
	{
	}

	protected override void OnHolstered()
	{
	}

	protected override void OnUnholstered()
	{
	}

	public override void OnEquip()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	public override void UpdateControllerUpdate()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}

	public override void OnLeaveVehicleWithWeapon()
	{
	}

	private void TriggerFire()
	{
	}

	public override void TriggerBegin(int instigator)
	{
	}

	public override void TriggerEnd()
	{
	}

	private void DoFire(bool isLocal)
	{
	}

	private void Fire(bool isLocal)
	{
	}

	private void OnBulletHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void OnLocalBulletHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}
}
