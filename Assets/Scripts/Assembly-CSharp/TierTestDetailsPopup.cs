using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class TierTestDetailsPopup : MonoBehaviour
{
	[SerializeField]
	private Text tierText;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	private GamePassTier tierToPurchase;

	public void Initialize(GamePassTier tierToPurchase, int price)
	{
	}

	public void ShowTier()
	{
	}

	public void Test()
	{
	}

	private void OnEnable()
	{
	}
}
