using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePopupTimed : FirstTimeActivatableElementBase
{
	[SerializeField]
	private CanvasGroup popupPrefab;

	[SerializeField]
	private float visibleDuration;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private List<UIPushOption> pushOptions;

	[SerializeField]
	private bool inputRequired;

	protected bool isShown;

	private float currentTime;

	private CanvasGroup createdPopup;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	private bool isFading;

	private bool isUpdating;

	private bool destroyCreatedPopup;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}

	protected void ParentPopupToGameObject()
	{
	}

	protected override void OnDestroy()
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
