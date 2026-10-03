using System.Collections.Generic;
using MV.Common;

public class MVEquipableProxy : MVEquipable
{
	private MVEquipable equipable;

	public void Init(MVEquipable equipable)
	{
	}

	public override bool Equip(AvatarItemType type, AvatarEquipableType equipType, Dictionary<object, object> itemData, int variantID = 0, bool holsterable = true)
	{
		return false;
	}

	public override void Unequip()
	{
	}

	public override void Holster()
	{
	}

	public override void Unholster()
	{
	}
}
