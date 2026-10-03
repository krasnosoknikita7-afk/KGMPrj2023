using UnityEngine;
using UnityEngine.UI;

public class AvatarPurchasePopup : MonoBehaviour
{
	[SerializeField]
	private Text avatarGoldCost;

	[SerializeField]
	private RawImage avatarImage;

	private AvatarRepositoryItem item;

	public void Initialize(RawImage image, AvatarRepositoryItem item)
	{
	}

	public void OnPurchaseClicked()
	{
	}
}
