using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatableEditToolPopup : FirstTimeActivatableElementBase
{
	[SerializeField]
	private List<EditCubeChange> cubeChangesToCheck;

	[SerializeField]
	private FirstTimeEventPopup popupPrefab;

	[SerializeField]
	private GameObject stackParent;

	private FirstTimeEventPopup popup;

	private bool showing;

	private bool wantsToShow;

	[SerializeField]
	protected bool skipAllowed;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	private void ShowPopup()
	{
	}

	private void Update()
	{
	}

	private void OnCubeChanged(int cubeCount, EditCubeChange changeMade)
	{
	}

	protected void OnShown()
	{
	}

	private void OnPopupRemoved(GameObject popupGameObject)
	{
	}
}
