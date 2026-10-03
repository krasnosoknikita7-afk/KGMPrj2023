using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabMenu : TabMenuBase
{
	private readonly Dictionary<int, TabMenuButtonBase> buttons;

	[SerializeField]
	private Text pages;

	[SerializeField]
	private TabMenuButtonBase tabMenuButtonPrefab;

	public override void AddTabMenuButton(int categoryIndex, string categoryName)
	{
	}

	public override void SelectTab(int tab, int currentPage, int maxPages)
	{
	}
}
