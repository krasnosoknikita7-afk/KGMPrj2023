using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeActivatableButtonPointer : FirstTimeActivatableElementBase
{
	protected int bubbleId;

	[SerializeField]
	protected Button button;

	[SerializeField]
	protected RectTransform pointToTransform;

	[SerializeField]
	protected Vector2 pointerBodyDirectionOffset;

	[SerializeField]
	protected List<RectTransform> bubbleContent;

	[SerializeField]
	protected float bubbleLifetimeWhileShown;

	[SerializeField]
	protected Button skipElement;

	[SerializeField]
	protected bool skipAllowed;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	private void CreateBubble()
	{
	}

	protected void ShowBubble()
	{
	}

	private void Clear()
	{
	}

	protected virtual void OnShown()
	{
	}
}
