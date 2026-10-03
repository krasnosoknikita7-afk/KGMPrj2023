using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AvatarAccessorySuccesPopup : MonoBehaviour
{
	[SerializeField]
	private RawImage preview;

	[SerializeField]
	private AccessoryItemBackground itemBackground;

	private UnityAction resultCallback;

	public void Initialize(UnityAction resultCallback, Texture previewImage, AccessoryDataClient accessoryData)
	{
	}

	public void OnButtonPressed()
	{
	}
}
