using UnityEngine;
using UnityEngine.Networking;

public class LevelDisplayCube : MonoBehaviour
{
	public GameObject cube;

	private Texture2D badgeTextureAsset;

	private bool waitingForBadgeTexture;

	private Renderer[] renderers;

	public Renderer[] Renderers => null;

	public void Initialize()
	{
	}

	public void SetAmount(int levelAmount)
	{
	}

	private void OnBadgeTextureReceived(UnityWebRequest www)
	{
	}

	public void Destroy()
	{
	}

	public void SetScale(Vector3 size)
	{
	}
}
