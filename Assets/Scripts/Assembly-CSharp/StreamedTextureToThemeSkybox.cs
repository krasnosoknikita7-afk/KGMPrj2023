using UnityEngine;

public class StreamedTextureToThemeSkybox : StreamingAsset<Texture, Texture>
{
	[SerializeField]
	private string shaderPropertyName;

	[SerializeField]
	private ThemeSkybox skybox;

	protected override void OnAssetSet()
	{
	}

	protected void Reset()
	{
	}
}
