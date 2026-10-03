using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabMenuAccessoryShop : TabMenuBase
{
	[Serializable]
	private class TabMenuButtonNonLayoutDef
	{
		public AccessoryCategoryClient category;

		public TabMenuButtonBase tabMenuButton;
	}

	private Dictionary<int, TabMenuButtonBase> buttons;

	[SerializeField]
	private Text pages;

	[SerializeField]
	private TabMenuButtonBase tabMenuButtonPrefab;

	[SerializeField]
	private List<GameObject> pageButtons;

	[SerializeField]
	private List<TabMenuButtonNonLayoutDef> nonLayoutTabButtons;

	public TabMenuButtonBase GetTabMenuButton(AccessoryCategoryClient category)
	{
		return null;
	}

	public void DestroyTab(AccessoryCategoryClient category)
	{
	}

	public override void AddTabMenuButton(int categoryIndex, string categoryName)
	{
	}

	public override void SelectTab(int tab, int currentPage, int maxPages)
	{
	}
}
