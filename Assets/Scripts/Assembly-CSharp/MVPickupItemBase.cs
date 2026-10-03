using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class MVPickupItemBase : MVLogicObject, IPickupStateHandler, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public const string ItemDataKey = "itemData";

	public const string ItemTypeKey = "itemType";

	public const string VariantIdKey = "variantId";

	public const float PickupRotationSpeed = 68f;

	private const UseGUIResult PurchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	protected UseInteractor useInteractor;

	protected int pickupVariantId;

	protected AvatarItemType pickupItemType;

	private readonly MVWorldObjectDocumentationType documentationType;

	private bool canPickUp;

	private readonly List<int> instigatorsInTrigger;

	private static readonly Dictionary<AvatarItemType, MVWorldObjectDocumentationType> avatarItemToToinventoryItemDescrip;

	protected override bool HasVisualsInPlaymode => false;

	public AvatarItemType Type => AvatarItemType.LaserPointer;

	public int VariantID => 0;

	public Dictionary<object, object> ItemData => null;

	public MVPickupItemBaseObject BaseObject { get; protected set; }

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	private static ObjectPrefab GetPickupPrefabName(Dictionary<object, object> data)
	{
		return null;
	}

	public MVPickupItemBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	private void SetupUseInteractor()
	{
	}

	protected virtual void AddExtraUseRequirements(GameObject root, UseInteractor ui)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public override void InitializeInventory()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	protected bool CheckCanUse(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	protected virtual bool CheckCanUse()
	{
		return false;
	}

	protected bool DoPickup(int instigatorWOID)
	{
		return false;
	}

	public void HandleStateChange(PickupItemState state)
	{
	}

	private bool ShouldDoAutoPickup(int instigator)
	{
		return false;
	}

	private bool TryGetPickupOwner(int instigator, out MVPickupOwner pickupOwner)
	{
		pickupOwner = null;
		return false;
	}

	protected virtual bool IsSameWeapon(PickupItem pickupItem)
	{
		return false;
	}

	void IUpdatecontrollerSubscriberUpdate.UpdateControllerUpdate()
	{
	}
}
