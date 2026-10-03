using System.Collections.Generic;
using MV.Common;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PickupItemImpulseGun : PickupItem
{
	public Transform chargeObject;

	public float hitImpulse;

	public float recoilImpulse;

	public float maxRange;

	public float chargingRate;

	public float radius;

	public ImpulseRay impulseRayPrefab;

	public Color hitColor;

	public Color missColor;

	public float shakeFrequency;

	public float shakePower;

	public Vector3 shakeDirection;

	public AudioClip chargeSound;

	public AudioClip releaseSound;

	public AnimationCurve chargeCurve;

	public AnimationCurve shakeCurve;

	[SerializeField]
	private Transform modelTransform;

	[SerializeField]
	private AudioSource audioSource;

	private float maxVolume;

	private bool isCharging;

	private float chargeBeginTime;

	protected override bool IsAmmoDepleted => false;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	public override float ChargeState => 0f;

	private void Awake()
	{
	}

	private void DoChargingAnimation()
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	private void Update()
	{
	}

	public override void TriggerEnd()
	{
	}

	private void Fire(int avatarId, float impulseMagnitude, float recoilMagnitude)
	{
	}

	private List<MVWorldObjectClient> SphereCastAgainstWorldObjects(Ray lineOfFire)
	{
		return null;
	}

	private Vector3 FindRayTarget(Ray lineOfFire)
	{
		return default;
	}

	private Vector3 ComputeImpulseDirection(Ray lineOfFire)
	{
		return default;
	}
}
