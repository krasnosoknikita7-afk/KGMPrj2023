using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePopup : FirstTimeActivatableElementBase
{
	[SerializeField]
	private FirstTimeEventPopup popupPrefab;

	[SerializeField]
	private List<UIPushOption> pushOptions;

	[SerializeField]
	protected bool skipAllowed;

	protected FirstTimeEventPopup popup;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	protected virtual void DoShow()
	{
	}

	protected void CreatePopup()
	{
	}

	private void PushToStack()
	{
	}

	private void OnPop()
	{
	}
}
