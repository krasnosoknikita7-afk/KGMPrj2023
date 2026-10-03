using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemRailGun : PickupItemWithDelay
{
	public ParticleSystem chargeParticles;

	[SerializeField]
	private float range;

	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private RailRay railGunRayPrefab;

	[SerializeField]
	private float targetFieldOfView;

	[SerializeField]
	private ObscuredFloat baseDamage;

	[SerializeField]
	private Color hitColor;

	[SerializeField]
	private Color missColor;

	[SerializeField]
	private AudioSource releaseSound;

	[SerializeField]
	private AudioSource chargeAudioSource;

	[SerializeField]
	private AnimationCurve chargeCurve;

	[SerializeField]
	private float curveChargeLength;

	private float toFieldOfView;

	private float initialFOV;

	private bool canDoFOVZoom;

	private bool isCharging;

	private float chargeBeginTime;

	private ObscuredInt currentAmmo;

	private float currentCharge;

	private int hitLayerMask;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	protected override bool IsAmmoDepleted => false;

	public override int Quantity => 0;

	public override float ChargeState => 0f;

	public override Color CrossHairColor => default;

	private void Awake()
	{
	}

	public override void ResetAmmo()
	{
	}

	public override void OnLeaveVehicleWithWeapon()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}

	private void DoChargingAnimation()
	{
	}

	private void Update()
	{
	}

	public override void OnEquip()
	{
	}

	public override void OnUnequip()
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	public override void TriggerEnd()
	{
	}

	private void Fire()
	{
	}
}
