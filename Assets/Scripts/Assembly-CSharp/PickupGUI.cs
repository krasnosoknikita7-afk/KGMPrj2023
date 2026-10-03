using UnityEngine;

public class PickupGUI : MonoBehaviour
{
	private IGUICrossHair crossHair;

	private MVPickupOwner pickupOwner;

	private int worldObjectId;

	private bool canBeVisible;

	public static PickupGUIFlags ShowEquipableUI { get; private set; }

	public void Initialize(int worldObjectId, MVPickupOwner pickupOwner)
	{
	}

	public void OnHolstered(bool isHolstered)
	{
	}

	private bool IsInJetpack()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public void Enter()
	{
	}

	public void Leave()
	{
	}

	private void UpdateCrossHairVisibility()
	{
	}

	public void AvatarLeftVehicle()
	{
	}

	private void OnEquipItem(PickupItem item)
	{
	}

	private void OnUnequipItem(PickupItem item)
	{
	}
}
