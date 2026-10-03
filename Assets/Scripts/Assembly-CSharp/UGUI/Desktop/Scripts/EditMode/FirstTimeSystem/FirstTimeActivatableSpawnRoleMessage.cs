using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.FirstTimeSystem
{
	public class FirstTimeActivatableSpawnRoleMessage : FirstTimeActivatableButtonPointer
	{
		[SerializeField]
		private bool inventoryButton;

		private readonly WorldObjectTypeInShopChecker inShopChecker;

		public override bool CanShow => false;

		private void Register()
		{
		}
	}
}
