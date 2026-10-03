using UnityEngine;
using UnityEngine.Networking;

public class MaterialLoader : MonoBehaviour
{
	private const string highResAtlasFileName = "AssetBundles/Atlas/atlas.unity3d";

	[SerializeField]
	private Material cubeModelMaterialHigh;

	[SerializeField]
	private Material cubeModelMaterialLow;

	[SerializeField]
	private Material cubeModelMaterialMobile;

	[SerializeField]
	private Shader pickupItemShader;

	[SerializeField]
	private Shader wireframeShader;

	[SerializeField]
	private Shader defaultDiffuseShader;

	[SerializeField]
	private Texture2D lowResMaterials;

	private uint atlasHash;

	public Material CubeModelMaterial { get; private set; }

	public Shader PickupItemShader => null;

	public Shader WireframeShader => null;

	public Shader DefaultDiffuseShader => null;

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	protected void OnDestroy()
	{
	}

	public bool CheckAtlasIntegrity()
	{
		return false;
	}

	private void SetMainTexture(Texture2D texture)
	{
	}

	private void SetupMaterials()
	{
	}

	public void Initialize()
	{
	}

	private void DownloadWhenPossible()
	{
	}

	private Texture2D FixTexture(Texture2D source)
	{
		return null;
	}

	private void Callback(UnityWebRequest www)
	{
	}

	private void InitAllMaterials(bool useSM3)
	{
	}

	private uint Hash(Texture2D tex)
	{
		return 0u;
	}
}
