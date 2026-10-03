using UnityEngine;
using UnityEngine.UI;

public class UploadGameScreenshotHandler : MonoBehaviour
{
	[SerializeField]
	private AudioSource screenShotSound;

	[SerializeField]
	private RawImage fromImage;

	[SerializeField]
	private RawImage toImage;

	public void TakeScreenshot()
	{
	}

	private void OnScreenshotReady(byte[] imageData)
	{
	}

	public void UploadScreenshot()
	{
	}

	private void OnScreenShotUploaded(object sender, ScreenshotUploadedEventArgs args)
	{
	}
}
