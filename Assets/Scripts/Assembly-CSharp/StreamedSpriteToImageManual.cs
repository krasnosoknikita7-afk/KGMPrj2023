using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

public class StreamedSpriteToImageManual : StreamingAsset<Sprite, Texture2D>
{
	private class StreamedAssetSpriteHandler
	{
		private static Dictionary<string, Sprite> sprites;

		public static Sprite GetSprite(string url)
		{
			return null;
		}

		public static void CacheSpriteUrl(string url, Sprite sprite)
		{
		}
	}

	[Header("Dependencies")]
	[SerializeField]
	protected Image image;

	private UnityAction onAssetSetManual;

	protected override void Start()
	{
	}

	public void Download(string url, UnityAction onAssetSet)
	{
	}

	protected override void OnDownloadFinished(UnityWebRequest www)
	{
	}

	private void OnAssetSetCallback()
	{
	}

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
