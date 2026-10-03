using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesXpRewardInfo : MonoBehaviour, IGamePassShopContent
{
	[SerializeField]
	private Image TeamRequirementImage;

	[SerializeField]
	private GameObject optionsButton;

	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private GamePassesXPRewardOption xPRewardOption;

	[SerializeField]
	private Text xPAmountText;

	[SerializeField]
	private Text bonusXPAmountText;

	[SerializeField]
	private GameObject subscriberUI;

	[SerializeField]
	private GameObject claimedText;

	private GamePassTier tier;

	public void Initialize(GamePassTier tier)
	{
	}

	public void OnOptionsButtonPress()
	{
	}

	public void OnGameProgressionDataUpdate()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void ChangeBackground(GamePassTier tier)
	{
	}

	private void UpdateXPText()
	{
	}

	private void UpdateXPTextVisibility()
	{
	}

	private void OnDestroy()
	{
	}
}
