using System;
using System.Collections.Generic;
using MV.Common;

public class AvatarEquipable : MVEquipable
{
	private MVInteractableBase interactableLocal;

	private MVRuntimeDataVariable currentItem;

	private bool isAbleToCollectPickups;

	private bool isAbleToEquipWeapons;

	private List<AvatarItemType> nonWeaponPickups;

	public void Init(MVInteractableBase interactableLocal, MVRuntimeDataVariable currentItem, WorldObjectSkillDataManager skillsDataManager)
	{
	}

	public override bool Equip(AvatarItemType type, AvatarEquipableType equipType, Dictionary<object, object> itemData, int variantID = 0, bool holsterable = true)
	{
		return false;
	}

	public override void Holster()
	{
	}

	public override void Unholster()
	{
	}

	public bool GetIsEquipped(AvatarItemType type)
	{
		return false;
	}

	public void EquipSlapGun(object sender, EventArgs e)
	{
	}

	public override void Unequip()
	{
	}
}
