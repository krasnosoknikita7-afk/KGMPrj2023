using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesShopContentCuller : MonoBehaviour
{
	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private int maxSelectionElementsOnScreen;

	private int currentSelectionStartIndex;

	private List<IGamePassShopContent> gamePassShopContentList;

	public void AddContentElement(IGamePassShopContent gamePassContentElement)
	{
	}

	public void Initialize()
	{
	}

	public void OnScrollValueChanged()
	{
	}

	private void UpdateShownElements()
	{
	}

	private bool IsIndexWithinBounds(int index)
	{
		return false;
	}

	private void ShowElements(int startElementIndex)
	{
	}

	private void HideElements(int previousStartElement, int amoutOfElements, int newStartElement)
	{
	}
}
