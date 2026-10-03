using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class PickupItemCollectTheItem : PickupItem
{
	[SerializeField]
	private Transform cubeModelAttachPoint;

	[SerializeField]
	private float pickupScale;

	private ObjectiveArrow arrow;

	private MVWorldObjectClient woDropOff;

	private int cubeModelKeyId;

	private int spawnerId;

	private int dropOffId;

	private GameObject pickup;

	private bool shouldSpawnInstanceOnUnequip;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override bool ActivateGunModeOnEquip => false;

	private void Awake()
	{
	}

	public override void UpdateWithDirection(Vector3 dir)
	{
	}

	public override void OnLeaveVehicleWithWeapon()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}

	public override void OnUnequip()
	{
	}

	public void SetShouldSpawnInstanceOnUnequip(bool shouldSpawnInstance)
	{
	}

	public override void OnEquip()
	{
	}

	public int GetCubeModelKeyId()
	{
		return 0;
	}

	private void OnDropoffActivated(bool shouldStayEquipped)
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	private void SetupDropOffArrow(int dropoffId)
	{
	}

	private void SetupPickupWo(MVWorldObjectClient wo)
	{
	}

	private void OnWorldObjectSpawnerDestroyed()
	{
	}

	private void ForceUnequipPickup()
	{
	}

	private void OnDestroy()
	{
	}
}
