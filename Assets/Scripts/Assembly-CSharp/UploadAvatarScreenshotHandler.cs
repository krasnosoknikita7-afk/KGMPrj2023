using System;
using UnityEngine;
using UnityEngine.UI;

public class UploadAvatarScreenshotHandler : MonoBehaviour
{
	[SerializeField]
	private AvatarScreenShooter screenShooter;

	[SerializeField]
	private PleaseWaitPopup pleaseWaitPopupPrefab;

	[SerializeField]
	private GameObject invisibleBlocker;

	[SerializeField]
	private RawImage fromImage;

	[SerializeField]
	private RawImage toImage;

	private Action<Texture2D, string> OnUploadScreenshot;

	private MVBody avatarBody;

	public void TakeScreenshot(MVBody currentBody, Action<Texture2D, string> onUploadScreenshot, bool purchasedAvatar = false)
	{
	}

	public void TakePurchasedScreenshot(MVBody currentBody, Action<Texture2D, string> onUploadScreenshot, bool purchasedAvatar = true)
	{
	}

	private void PrepareScreenshot(MVBody currentBody, Action<Texture2D, string> onUploadScreenshot, bool purchasedAvatar, out string successText)
	{
		successText = null;
	}

	private void OnScreenshotReadyUploadDirect(Texture2D texture, string text)
	{
	}

	private void OnScreenshotReady(Texture2D texture, string text)
	{
	}

	public void OnUpdatePressed()
	{
	}

	private void UploadAndDestroy(Texture2D texture, string successText)
	{
	}
}
