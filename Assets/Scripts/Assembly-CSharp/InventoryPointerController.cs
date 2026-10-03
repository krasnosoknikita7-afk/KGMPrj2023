using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPointerController : MonoBehaviour
{
	private int bubbleId;

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
	private Button openButton;

	private int slotToHighlight;

	private int categoryToOpen;

	private Button open;

	private void Start()
	{
	}

	public void CreateBubble(int category, int slot, bool showBubble)
	{
	}

	private void RemoveBubbles()
	{
	}

	private void OpenAtSlot()
	{
	}

	private void ClearImmediate()
	{
	}
}
