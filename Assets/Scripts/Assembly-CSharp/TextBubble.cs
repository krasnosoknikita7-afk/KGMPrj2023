using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBubble : MonoBehaviour
{
	[SerializeField]
	[Header("Dependencies")]
	private LayoutGroup bubble;

	[SerializeField]
	private RectTransform tail;

	[SerializeField]
	private CanvasGroup fadeGroup;

	[NonSerialized]
	public new Transform transform;

	private List<UnityEngine.Object> content;

	[SerializeField]
	private Vector2 centerPoint;

	private int bubbleId;

	public Vector2 Position
	{
		private get
		{
			return default;
		}
		set
		{
		}
	}

	private RectTransform BubbleTransform => null;

	private float HorizontalPadding => 0f;

	private float VerticalPadding => 0f;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize(Vector2 center, int bubbleId)
	{
	}

	public void OnRemoved()
	{
	}

	public void Add(RectTransform transformContent)
	{
	}

	public void ClearContent()
	{
	}

	private void RecalcPositionWithScreenCollision()
	{
	}

	public void RecalcPositionAndSize(int inside)
	{
	}

	public void SetTransparancy(float a)
	{
	}

	protected void OnValidate()
	{
	}

	private float CalculatePivotNearEdgeOffset(float pivot)
	{
		return 0f;
	}
}
