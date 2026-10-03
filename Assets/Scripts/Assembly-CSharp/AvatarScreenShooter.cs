using System;
using UnityEngine;

public class AvatarScreenShooter : MonoBehaviour
{
	private bool isMakingScreenShot;

	[SerializeField]
	private GameObject bodyCloneGO;

	public Vector3 cameraOffset;

	public Vector3 lookAtOffset;

	public Rect previewPosition;

	private Action<Texture2D, string> callback;

	private string successMessage;

	public void TakeScreenShot(Action<Texture2D, string> callback, MVBody body, bool ignoreAccessories = false, string successMessage = "Screenshot taken successfully!")
	{
	}

	private void ScreenShotDataTexHandler(Texture2D screenshotTex)
	{
	}
}
