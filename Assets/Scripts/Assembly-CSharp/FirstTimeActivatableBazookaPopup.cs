using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatableBazookaPopup : FirstTimeActivatableElementBase
{
	private Dictionary<MVWorldObjectDocumentationType, int> priorityDictionary;

	[SerializeField]
	private TabMenu tabGroup;

	[SerializeField]
	private InventorySlots slots;

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
