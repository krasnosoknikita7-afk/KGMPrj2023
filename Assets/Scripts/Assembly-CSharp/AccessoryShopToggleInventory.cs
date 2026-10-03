using UnityEngine;
using UnityEngine.UI;

public class AccessoryShopToggleInventory : MonoBehaviour
{
	[SerializeField]
	private Toggle toggle;

	[SerializeField]
	private GameObject backpackOn;

	[SerializeField]
	private GameObject backpackOff;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Image checkBox;

	[SerializeField]
	private Color toggleOnColor;

	[SerializeField]
	private Color toggleOffColor;

	public void SetBackpackIconIsEnabled(bool enable)
	{
	}

	public void OnValueChanged()
	{
	}
}
