using System;
using UGUI.Desktop.Scripts.EditMode.Inventories;

public interface IEditModeUI
{
	bool IsInPlayInEditMode { get; }

	Action<EditModeChangeArgs> EditModeChange { get; set; }

	PlayerShopInventoryRepository PlayerShopInventoryRepository { get; set; }

	bool IsGridSnap();
}
