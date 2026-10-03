using UnityEngine;
using UnityEngine.UI;

public class TestItem : MonoBehaviour
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private RawImage image;

	[SerializeField]
	private InventoryItemMetaData inventoryItemMetaData;

	[SerializeField]
	private PreviewObject previewObject;

	public Texture2D Texture
	{
		set
		{
		}
	}

	public void Initialize(string text, int slotIndex)
	{
	}

	private void OnDestroy()
	{
	}
}
