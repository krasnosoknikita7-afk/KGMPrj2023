using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.FirstTimeSystem
{
	public class FirstTimeActivatableClientShopInventoryGotoCategory : FirstTimeActivatableElementBase
	{
		[SerializeField]
		private bool insideInventory;

		private bool showing;

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
	}
}
