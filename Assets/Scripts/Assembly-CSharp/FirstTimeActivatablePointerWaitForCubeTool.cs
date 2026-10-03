using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePointerWaitForCubeTool : FirstTimeActivatableElementBase
{
	[SerializeField]
	private bool checkCubeCount;

	[SerializeField]
	private List<EditCubeChange> cubeChangesToCheck;

	[SerializeField]
	private int numberOfChangesBeforePointer;

	[SerializeField]
	private FirstTimeEventPopupWithProgress meanwhilePopup;

	private FirstTimeEventPopupWithProgress popup;

	private int currentChangeCount;

	private bool isShown;

	private bool canShow;

	private bool completed;

	[SerializeField]
	protected bool skipAllowed;

	public override bool CanShow => false;

	public override void OnActivate()
	{
	}

	public override void OnShow()
	{
	}

	private void OnCubeChanged(int cubeCount, EditCubeChange changeMade)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnClosed()
	{
	}

	protected void OnShown()
	{
	}

	private void OnPopupRemoved(GameObject popupGameObject)
	{
	}
}
