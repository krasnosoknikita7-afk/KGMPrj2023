using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePointerGameMeters : FirstTimeActivatableElementBase
{
	[SerializeField]
	private Vector2 pointerBodyDirectionOffset;

	[SerializeField]
	private List<RectTransform> bubbleContent;

	[SerializeField]
	private RectTransform pointToTransform;

	[SerializeField]
	private float bubbleLifetimeWhenVisible;

	[SerializeField]
	private float visibleDuration;

	private bool visible;

	private float currentTime;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	private bool isUpdating;

	private int bubbleId;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}

	private void CreateBubble()
	{
	}

	private void Clear()
	{
	}

	private void OnShown()
	{
	}

	private void Destroy()
	{
	}
}
