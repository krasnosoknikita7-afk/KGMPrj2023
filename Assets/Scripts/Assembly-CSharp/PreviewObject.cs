using UnityEngine;

public class PreviewObject : MonoBehaviour
{
	[SerializeField]
	private Camera previewCamera;

	[SerializeField]
	private Transform previewTransform;

	[SerializeField]
	private int width;

	[SerializeField]
	private int height;

	[SerializeField]
	private int depth;

	[SerializeField]
	private int antiAliasing;

	[SerializeField]
	private FilterMode filterMode;

	[SerializeField]
	private RenderTexture renderTexture;

	public RenderTexture RenderTexture => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
