using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using MV.WorldObject;

namespace Assets.Scripts.WorldObjectTypes.MeleeWeapon
{
	public class MVMeleeWeaponBase : MVEditablePickupItemBase
	{
		public MVMeleeWeaponBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override (IntVector, IntVector) GetEditPoints()
		{
			return default;
		}
	}
}
