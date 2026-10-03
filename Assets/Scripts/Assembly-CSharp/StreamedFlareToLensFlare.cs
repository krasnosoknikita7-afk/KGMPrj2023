using UnityEngine;

public class StreamedFlareToLensFlare : StreamingAsset<Flare, Flare>
{
	[SerializeField]
	private LensFlare lensFlare;

	protected override void OnAssetSet()
	{
	}

	protected void Reset()
	{
	}
}
