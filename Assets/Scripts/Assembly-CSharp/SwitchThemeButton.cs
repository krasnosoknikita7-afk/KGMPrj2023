using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SwitchThemeButton : MonoBehaviour
{
	[SerializeField]
	private GameObject levelReq;

	[SerializeField]
	private RawImage levelReqImage;

	[SerializeField]
	private GameObject priceTag;

	[SerializeField]
	private Text priceTagNumber;

	[SerializeField]
	private GameObject memberUI;

	[SerializeField]
	private Button button;

	private Texture2D levelRequirementTextureAsset;

	public Button Button => null;

	private int LevelRequirement
	{
		set
		{
		}
	}

	private int GoldRequirement
	{
		set
		{
		}
	}

	public void Initialize(int levelReq, int goldReq)
	{
	}

	private void OnLevelTextureReceived(UnityWebRequest www)
	{
	}

	protected void OnDestroy()
	{
	}

	protected void Reset()
	{
	}
}
