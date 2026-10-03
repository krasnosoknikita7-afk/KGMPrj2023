using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;

namespace Assets.Scripts.WorldObjectTypes.MeleeWeapon
{
	public class MVMeleeWeaponBaseBlueprint : MVEditablePickupItemBaseBlueprint
	{
		public const int LegacySwordVariantId = 1;

		public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

		public MVMeleeWeaponBaseBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void OnEndEditing()
		{
		}
	}
}
