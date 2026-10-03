using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemCenterGun : PickupItemWithDelay
{
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private ParticleSystem muzzleFlare;

	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private float projectileSpeed;

	[SerializeField]
	private float range;

	[SerializeField]
	private float impulseStrength;

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

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	public override void TriggerEnd()
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
