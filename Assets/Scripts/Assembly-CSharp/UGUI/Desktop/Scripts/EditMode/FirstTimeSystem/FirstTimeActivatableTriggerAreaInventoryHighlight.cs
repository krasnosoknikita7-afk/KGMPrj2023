using MV.WorldObject.MetaData;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.FirstTimeSystem
{
	public class FirstTimeActivatableTriggerAreaInventoryHighlight : FirstTimeActivatableElementBase
	{
		[SerializeField]
		private bool insideInventory;

		[SerializeField]
		private TabMenu tabGroup;

		[SerializeField]
		private InventorySlots slots;

		private bool showing;

		private const InventoryCategoryType ItemCategory = InventoryCategoryType.AdvancedLogic;

		private readonly WorldObjectTypeInShopChecker inShopChecker;

		private readonly FirstTimeGuiHandler firstTimeGuiHandler;

		public override bool CanShow => false;

		public override void OnShow()
		{
		}

		private void DoShowing()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnFirstTimeState(FirstTimeState firstTimeState, FirstTimeEvent latestFirstTimeEvent)
		{
		}

		private void Register()
		{
		}
	}
}
