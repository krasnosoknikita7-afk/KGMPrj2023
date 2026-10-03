using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelErrorPopup : MonoBehaviour
{
	[SerializeField]
	private RawImage requiredLevelImage;

	[SerializeField]
	private RawImage playerLevelImage;

	private UnityAction resultCallback;

	private Texture2D requiredLevelTextureAsset;

	private Texture2D playerLevelTextureAsset;

	public void Initialize(UnityAction resultCallback, int requiredLevel)
	{
	}

	private void OnLevelRequirementLoaded(UnityWebRequest www)
	{
	}

	private void OnPlayerLevelLoaded(UnityWebRequest www)
	{
	}

	public void OnButtonPressed()
	{
	}

	private void OnDestroy()
	{
	}
}
