using UnityEngine;

public class StreamedAudioClipToAudioSource : StreamingAsset<AudioClip, AudioClip>
{
	[Header("Dependencies")]
	[SerializeField]
	protected AudioSource audioSource;

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
