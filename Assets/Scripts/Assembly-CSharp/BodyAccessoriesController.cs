using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.Avatar.Accessories;
using MV.Common;
using UnityEngine;

public class BodyAccessoriesController
{
	private static Dictionary<AccessorySlotType, string> slotBoneNameMap;

	private static Dictionary<AccessorySlotType, Vector3> slotBoneOffset;

	private bool accessoryMoveOverride;

	private Dictionary<AccessorySlotType, AvatarAccessory> accessoryMap;

	private AccessoryLoader accessoryLoader;

	private Dictionary<object, object> accessoryData;

	private BodyData bodyData;

	private int bodyWoId;

	private bool accessoriesVisible;

	public Dictionary<object, object> AccessoryData => null;

	public bool AccessoryMoveOverride
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float GetOffset(AccessorySlotType accessorySlot)
	{
		return 0f;
	}

	public float GetScale(AccessorySlotType accessorySlot)
	{
		return 0f;
	}

	public BodyAccessoriesController(int bodyWoId, BodyData bodyData, Dictionary<object, object> accessoryData, bool isVisible)
	{
	}

	public bool IsAccessoryEquipped(int streamingAssetId)
	{
		return false;
	}

	public void Destroy()
	{
	}

	public Vector3 GetSlotPosition(AccessorySlotType slot, Vector3 offset)
	{
		return default;
	}

	private bool AttachAccessory(AvatarAccessory acc, AccessorySlotType slot, float offset, float scale)
	{
		return false;
	}

	private Transform GetSlotTransform(AccessorySlotType slot)
	{
		return null;
	}

	public void UpdateAccessoryVisibility(bool visible)
	{
	}

	public void ApplySizeChange(float size, AccessorySlotType slot)
	{
	}

	public void ApplyAccessoryOffset(float yOffset, AccessorySlotType slot)
	{
	}

	public void RefreshAccessories(Dictionary<object, object> accessoryData)
	{
	}

	private void UpdateScale(AccessorySlotType slot, float scale)
	{
	}

	private void UpdateOffset(AccessorySlotType slot, float offset)
	{
	}

	private void DestroyAccessory(AccessorySlotType slot)
	{
	}

	private bool IsAccessoryInWoData(AvatarAccessory avatarAccessory)
	{
		return false;
	}

	private void LoadedAccessoryCallback(AvatarAccessory accessory, AccessorySlotType slot)
	{
	}

	public bool IsAccessorySlotOccupied(AccessorySlotType accessorySlotType)
	{
		return false;
	}

	private bool AccessoryShouldBeSelecable(AvatarAccessory accessory)
	{
		return false;
	}

	private void MakeAccessorySelectable(AvatarAccessory accessory, AccessorySlotType accessorySlot)
	{
	}
}
