using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemShotgun : PickupItemWithDelay
{
	[SerializeField]
	private ParticleSystem muzzleFlare;

	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private float spread;

	[SerializeField]
	private float impulseStrength;

	[SerializeField]
	private float maxRange;

	[SerializeField]
	private float bulletSpeed;

	[SerializeField]
	private AudioSource audioSource;

	private static readonly float hitDamage;

	private static readonly float[] offsetsX;

	private static readonly float[] offsetsY;

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
