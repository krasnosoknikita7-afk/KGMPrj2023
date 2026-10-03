using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemDoubleSixShooter : PickupItemWithDelay
{
	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private float recoilImpact;

	[SerializeField]
	private float bulletRange;

	[SerializeField]
	private float bulletSpeed;

	[SerializeField]
	private float hitImpact;

	[SerializeField]
	private AudioSource fireSound;

	[SerializeField]
	private Transform muzzlePoint2;

	[SerializeField]
	private ParticleSystem muzzleParticles;

	[SerializeField]
	private Animation animComponentL;

	[SerializeField]
	private Animation animComponentR;

	private ObscuredInt currentAmmo;

	private static readonly float baseDamage;

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
