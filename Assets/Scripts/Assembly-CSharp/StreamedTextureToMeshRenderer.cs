using UnityEngine;

public class StreamedTextureToMeshRenderer : StreamingAsset<Texture, Texture>
{
	[Tooltip("For standard unity shaders \"_MainTex\" is the main textures name.")]
	[Header("Configuration")]
	[SerializeField]
	protected string shaderTextureVariableName;

	[SerializeField]
	[Header("Dependencies")]
	private MeshRenderer meshRenderer;

	public Texture TextureAsset => null;

	public void ReDownload()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
