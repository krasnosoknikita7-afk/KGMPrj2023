using MV.Common;
using UnityEngine;

public class VehiclePickupOwner : MVPickupOwner
{
	private Transform mountTransform;

	public void Init(MVRuntimeDataVariable currentItemRuntimeVariable, MVRuntimeDataVariable isFiringRuntimeVariable, Transform mountTransform)
	{
	}

	public void OnLocalObjectsDestroyed()
	{
	}

	protected override void Equip(AvatarItemType type, int variantId)
	{
	}

	protected override void Unequip()
	{
	}
}
