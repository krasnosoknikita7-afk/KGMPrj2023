using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AvatarAccessoryErrorPopup : MonoBehaviour
{
	[SerializeField]
	private StreamedSpriteToImageManual preview;

	[SerializeField]
	private AccessoryItemBackground itemBackground;

	[SerializeField]
	private Text header;

	[SerializeField]
	private Text buttonText;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private GameObject emptyFrame;

	private UnityAction<bool> resultCallback;

	public void Initialize(UnityAction<bool> resultCallback, string previewImageUrl, AccessoryDataClient accessoryData, string header, string buttonText)
	{
	}

	public void OnButtonPressed(bool confirmed)
	{
	}

	private void OnPreviewImageDownLoaded()
	{
	}
}
