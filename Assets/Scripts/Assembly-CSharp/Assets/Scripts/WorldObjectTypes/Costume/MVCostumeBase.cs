using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using MV.WorldObject;

namespace Assets.Scripts.WorldObjectTypes.Costume
{
	public class MVCostumeBase : MVEditablePickupItemBase
	{
		public MVCostumeBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override (IntVector, IntVector) GetEditPoints()
		{
			return default;
		}
	}
}
