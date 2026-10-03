using System.Collections.Generic;
using MV.Common;

public class VehicleEquipable : MVEquipable
{
	private MVInteractableBase interactableLocal;

	private MVRuntimeDataVariable currentItem;

	public void Init(MVInteractableBase interactableLocal, MVRuntimeDataVariable currentItem)
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

	public override void Unequip()
	{
	}
}
