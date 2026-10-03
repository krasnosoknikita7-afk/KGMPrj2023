using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemBazooka : PickupItemWithDelay
{
	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private ObscuredFloat baseDamage;

	[SerializeField]
	private float blastRadius;

	[SerializeField]
	private AnimationCurve damageFalloff;

	[SerializeField]
	private float baseImpulse;

	[SerializeField]
	private float rocketSpeed;

	[SerializeField]
	private float rocketRange;

	[SerializeField]
	private AudioSource aSource;

	private int layerMask;

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

	private void OnHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void OnHitLocal(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void OnHitMaxRangeRemote(Ray lineOfFire)
	{
	}

	private void OnHitMaxRangeLocal(Ray lineOfFire)
	{
	}
}
