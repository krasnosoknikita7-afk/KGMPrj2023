using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public abstract class PickupItem : MonoBehaviour
{
	protected bool firedThisFrame;

	public MVPickupOwner owner;

	[SerializeField]
	protected Transform muzzlePoint;

	[SerializeField]
	protected Transform holsterTransformOffset;

	[SerializeField]
	protected Transform firstPersonTransform;

	private Transform originalParent;

	private Vector3 originalPos;

	private Quaternion originalRot;

	private Vector3 originalScale;

	[SerializeField]
	protected Transform center;

	[SerializeField]
	protected MeshRenderer[] meshRenderers;

	public bool IsHolstered { get; private set; }

	protected virtual bool IsAmmoDepleted => false;

	public Vector3 Origin => default;

	public virtual int Quantity => 0;

	public virtual Color CrossHairColor => default;

	public virtual float ChargeState => 0f;

	public virtual bool ActivateGunModeOnEquip => false;

	public virtual bool CanHolster => false;

	public virtual bool HasUnlimitedAmmo => false;

	public bool FirstPersonCapable => false;

	public bool IsInFirstPersonMode => false;

	public bool IsAmmoEmpty => false;

	public virtual bool CanUnequip => false;

	public abstract AvatarItemType Type { get; }

	public int VariantID { get; set; }

	public static GameObject InstantiateAvatarItemType(AvatarItemType type, int variantId)
	{
		return null;
	}

	public void HolsterPickup(Transform targetHolsterTransform)
	{
	}

	public void UnholsterPickup()
	{
	}

	public void EnterFirstPersonView(MVCameraBase camera)
	{
	}

	public void LeaveFirstPersonView()
	{
	}

	private void RevertToOriginalTransform()
	{
	}

	private void AlignThisTo(Transform targetHolsterTransform, Transform offset)
	{
	}

	public virtual bool CanFire()
	{
		return false;
	}

	public virtual void TriggerBegin(int instigatorActorNr)
	{
	}

	public virtual void TriggerEnd()
	{
	}

	public virtual void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	public virtual void OnEquip()
	{
	}

	public virtual void OnUnequip()
	{
	}

	public virtual void ResetAmmo()
	{
	}

	public virtual void OnLeaveVehicleWithWeapon()
	{
	}

	public virtual void OnEnterVehicleWithWeapon()
	{
	}

	protected virtual void OnHolstered()
	{
	}

	protected virtual void OnUnholstered()
	{
	}

	protected virtual int GetAmmoMultiplier(int defaultAmmo)
	{
		return 0;
	}

	public virtual void UpdateWithDirection(Vector3 dir)
	{
	}

	public bool GetAndResetFiredThisFrame()
	{
		return false;
	}

	public static GameObject CloneCubeModelInstance(MVCubeModelInstance cmb, bool forceVisible = false)
	{
		return null;
	}

	private static GameObject InstantiateMeleeWeapon(int variantId)
	{
		return null;
	}
}
