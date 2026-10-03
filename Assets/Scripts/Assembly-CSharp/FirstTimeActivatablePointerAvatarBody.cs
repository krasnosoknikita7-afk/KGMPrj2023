using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeActivatablePointerAvatarBody : FirstTimeActivatableElementBase
{
	private bool showing;

	private bool hasButtonBeenAdded;

	private AvatarEditModeBodyController bodyController;

	[SerializeField]
	private List<RectTransform> bubbleContent;

	[SerializeField]
	private float bubbleLifetimeWhileShown;

	[SerializeField]
	private Vector3 bubbleWorldSpaceOffset;

	[SerializeField]
	private Button skipElement;

	[SerializeField]
	protected bool skipAllowed;

	[SerializeField]
	private Vector2 offset;

	private int bubbleId;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Clear()
	{
	}

	private void OnShown()
	{
	}
}
