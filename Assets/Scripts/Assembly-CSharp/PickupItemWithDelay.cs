using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public abstract class PickupItemWithDelay : PickupItem, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public Color crossHairCannotFireLow;

	public Color crossHairCannotFireHigh;

	public Color crossHairCanFire;

	[SerializeField]
	protected ObscuredFloat fireInterval;

	protected bool isFiring;

	private float lastFireTime;

	private bool triggerBegin;

	protected override bool IsAmmoDepleted => false;

	public override Color CrossHairColor => default;

	protected virtual void OnFire(bool isLocal)
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	public override void TriggerEnd()
	{
	}

	public override void OnEquip()
	{
	}

	private void Fire()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}
}
