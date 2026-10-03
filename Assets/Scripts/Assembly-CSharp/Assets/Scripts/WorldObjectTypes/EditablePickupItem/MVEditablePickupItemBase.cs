using System.Collections.Generic;
using MV.WorldObject;

namespace Assets.Scripts.WorldObjectTypes.EditablePickupItem
{
	public abstract class MVEditablePickupItemBase : MVPickupItemBase
	{
		private MVEditablePickupItemBaseBlueprint blueprint;

		public new MVEditablePickupItemBaseObject BaseObject
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public MVEditablePickupItemBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		private void SetupUseInteractor()
		{
		}

		public override void Initialize()
		{
		}

		public override void OnDataUpdate()
		{
		}

		private void OnDataUpdateBlueprintReq()
		{
		}

		public void UpdateUseInteractor(Dictionary<object, object> useInteractorData)
		{
		}

		protected override bool IsSameWeapon(PickupItem pickupItem)
		{
			return false;
		}

		public abstract (IntVector, IntVector) GetEditPoints();
	}
}
