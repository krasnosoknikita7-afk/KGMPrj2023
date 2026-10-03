using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePointerClickToSkip : FirstTimeActivatableElementBase
{
	private int bubbleId;

	[SerializeField]
	private RectTransform pointToTransform;

	[SerializeField]
	private Vector2 pointerBodyDirectionOffset;

	[SerializeField]
	private List<RectTransform> bubbleContent;

	[SerializeField]
	private float bubbleLifetimeWhileShown;

	private bool visible;

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

	private void Clear()
	{
	}

	private void OnShown()
	{
	}
}
