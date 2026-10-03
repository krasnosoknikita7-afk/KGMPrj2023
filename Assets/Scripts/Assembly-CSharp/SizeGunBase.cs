using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class SizeGunBase : PickupItemWithDelay
{
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private float range;

	[SerializeField]
	private ObscuredInt maxAmmo;

	[SerializeField]
	private Color hitColor;

	[SerializeField]
	private Color missColor;

	private ObscuredInt currentAmmo;

	private int layerMask;

	public override int Quantity => 0;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

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

	protected virtual InteractionData GetPackageData()
	{
		return default;
	}

	private void ReduceAmmo()
	{
	}
}
