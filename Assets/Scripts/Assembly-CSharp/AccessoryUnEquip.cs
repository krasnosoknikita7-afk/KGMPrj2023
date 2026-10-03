using MV.Common;
using UnityEngine;
using UnityEngine.Events;

public class AccessoryUnEquip : MonoBehaviour
{
	private AccessorySlotType avatarAccessorySlot;

	public UnityAction OnUnequipFinished;

	private MVBody AvatarBody;

	public void Initialize(AccessorySlotType avatarAccessorySlot, MVBody body)
	{
	}

	public void UnEquip()
	{
	}

	private void OnUnequipPop(bool setSlotSuccess)
	{
	}

	private void OnDestroy()
	{
	}

	private void Game_OnSetAvatarAccessorySlotResponseUnequipHandler(bool setSlotSuccess)
	{
	}
}
