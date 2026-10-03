using UnityEngine;
using UnityEngine.UI;

public class StreamedSpriteToImage : StreamingAsset<Sprite, Texture2D>
{
	[Header("Dependencies")]
	[SerializeField]
	protected Image image;

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
