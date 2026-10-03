using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.UI;

public class ClaimGoldRewardPopup : MonoBehaviour
{
	[SerializeField]
	private Text goldRewardText;

	[SerializeField]
	private GameObject goldRewardUnlockedPopupPrefab;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void OnClickClaimGoldAd()
	{
	}

	public void OnClickClaimGoldSubscriber()
	{
	}

	private void RewardedAdCallback(RewardedAdResult obj)
	{
	}

	private void OnAdFinished(bool adWasSuccessful)
	{
	}

	private void CreateErrorMessage()
	{
	}

	private void ClaimGold()
	{
	}
}
