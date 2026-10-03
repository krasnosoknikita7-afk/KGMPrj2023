using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class StreamPngToSprite : MonoBehaviour
{
	[SerializeField]
	[Header("Dependencies")]
	protected RawImage rawImage;

	private bool currentlyDownloading;

	public Action OnDownloadFinish;

	public void StartDownloading(string downloadUrl)
	{
	}

	public void CancelDownload()
	{
	}

	public void DestroyTexture()
	{
	}

	private void StreamingTextureLoaded(UnityWebRequest www)
	{
	}

	public void SetImageTexture(Texture texture)
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}
}
