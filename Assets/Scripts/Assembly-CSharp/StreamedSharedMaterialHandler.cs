using UnityEngine;

public class StreamedSharedMaterialHandler : MonoBehaviour
{
	[SerializeField]
	private StreamedTextureToSharedMaterial streamedTextureToSharedMaterialPrefab;

	private static bool streamComponentSet;

	public static void Reset()
	{
	}

	public void StartTextureStreaming()
	{
	}
}
