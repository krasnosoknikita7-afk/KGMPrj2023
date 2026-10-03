using UnityEngine;
using UnityEngine.UI;

public class AvatarSelectionSlot : MonoBehaviour
{
	[SerializeField]
	private RawImage image;

	[SerializeField]
	private RectTransform selectionOutline;

	public int BodyIndex { get; private set; }

	private void Awake()
	{
	}

	public void BuildAvatarSelectionSlot(int index, Texture2D texture)
	{
	}

	public void SlotClicked()
	{
	}

	public void ToggleActive(bool active)
	{
	}
}
