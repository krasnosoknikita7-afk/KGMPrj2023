using UnityEngine;

public class InGameButtons : TouchButtonsBase
{
	private PickupGUIFlags showingEquipableUI;

	[SerializeField]
	private RectTransform use;

	[SerializeField]
	private RectTransform fire;

	[SerializeField]
	private RectTransform point;

	[SerializeField]
	private RectTransform dropWeapon;

	[SerializeField]
	private RectTransform leaveVehicle;

	[SerializeField]
	private GameObject respawnButton;

	[SerializeField]
	private RectTransform holsterButton;

	[SerializeField]
	private RectTransform jumpButton;

	private void Update()
	{
	}

	private void HandleFireVisibility()
	{
	}

	public override void ShowEUseIcon(ShowUseOption option)
	{
	}

	public override void HideEUseIcon()
	{
	}

	private void HandleInPlayMode()
	{
	}

	private void HandleNotInPlayMode()
	{
	}
}
