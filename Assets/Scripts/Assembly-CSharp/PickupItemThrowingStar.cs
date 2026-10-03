using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemThrowingStar : PickupItemWithDelay
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
	private AudioSource fireSound;

	private static readonly float damage;

	private ObscuredInt currentAmmo;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	protected override bool IsAmmoDepleted => false;

	private void Awake()
	{
	}

	public override void ResetAmmo()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	private void OnBulletHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void OnLocalBulletHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}
}
