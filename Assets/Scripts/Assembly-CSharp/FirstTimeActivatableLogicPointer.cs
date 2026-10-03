using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeActivatableLogicPointer : FirstTimeActivatableElementBase
{
	private bool hasPlacedObject;

	private bool showing;

	private WorldObjectClientRef placedWo;

	private int bubbleId;

	private EditorStateMachine editorStateMachine;

	private bool hasButtonBeenAdded;

	private bool finishedESInsert;

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

	public override bool CanShow => false;

	protected override void Start()
	{
	}

	public override void OnShow()
	{
	}

	private void Update()
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
