using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public abstract class MVPickupOwner : MVComponent
{
	public delegate void OnEquipItemDelegate(PickupItem equippedItem);

	public delegate void OnUnequipItemDelegate(PickupItem unequippedItem);

	public delegate void OnHandleFiringDelegate(bool isFiring);

	private Vector3 lookOrigin;

	private Vector3 lookDirection;

	private float prevUpdateLineOfFireTime;

	private const float _updateLineOfFireInterval = 0.5f;

	private bool hasUnlimitedAmmoSetting;

	protected PickupItem currentItem;

	public OnEquipItemDelegate onEquipItem;

	public OnUnequipItemDelegate onUnequipItem;

	public OnHandleFiringDelegate onHandleFiring;

	public Action<bool> OnHolsteredChanged;

	public PickupItem CurrentItem => null;

	public bool IsLocal { get; set; }

	public Vector3 LookOrigin => default;

	public Vector3 LookDirection => default;

	public bool HasUnlimitedAmmo => false;

	public bool InGunMode => false;

	public bool PickupItemIsInHand => false;

	public MVWorldObjectClient WorldObjectOwner => null;

	public virtual HashSet<int> IgnoreWOIDs => null;

	protected abstract void Equip(AvatarItemType type, int variantId);

	protected abstract void Unequip();

	protected override void Awake()
	{
	}

	public float GetAbsolutProjectileSpeed(float projectileSpeed)
	{
		return 0f;
	}

	public void HandleFire(bool inputFire, MVRuntimeDataVariable isFiringRuntimeVariable)
	{
	}

	public void SetLineOfFire(Vector3 lookOrigin, Vector3 lookDirection)
	{
	}

	protected void Init(MVRuntimeDataVariable currentItemRuntimeVariable, MVRuntimeDataVariable isFiringRuntimeVariable)
	{
	}

	protected void InitializeSettings(bool hasUnlimitedAmmoSetting)
	{
	}

	private Vector3 GetLookDirectionWithAddedVelocityMagnitude(Vector3 lookDirection)
	{
		return default;
	}

	public void SetLineOfFireLocal()
	{
	}

	private void UpdateCurrentItem(Dictionary<object, object> newState)
	{
	}

	private Transform GetTargetHolsterTransform()
	{
		return null;
	}

	private void HandleFiring(bool isFiring)
	{
	}

	protected void SetAvatarItemAsCurrent(PickupItem avatarItem)
	{
	}

	protected PickupItem CreateAvatarItem(AvatarItemType type, int variantId)
	{
		return null;
	}
}
