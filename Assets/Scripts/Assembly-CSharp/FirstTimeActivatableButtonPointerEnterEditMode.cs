using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeActivatableButtonPointerEnterEditMode : FirstTimeActivatableElementBase
{
	private int bubbleId;

	[SerializeField]
	private EnterPlayModeButton button;

	[SerializeField]
	private RectTransform pointToTransform;

	[SerializeField]
	private Vector2 pointerBodyDirectionOffset;

	[SerializeField]
	private List<RectTransform> bubbleContent;

	[SerializeField]
	private float bubbleLifetimeWhileShown;

	[SerializeField]
	private Button skipElement;

	[SerializeField]
	protected bool skipAllowed;

	private bool shouldBeDelayedDestroyed;

	public override bool CanShow => false;

	public override void OnActivate()
	{
	}

	public override void OnShow()
	{
	}

	private void CreateBubble()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Clear()
	{
	}

	protected void OnShown()
	{
	}

	protected override void OnEnable()
	{
	}
}
