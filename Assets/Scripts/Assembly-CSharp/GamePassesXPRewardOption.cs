using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesXPRewardOption : MonoBehaviour
{
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private Text bonusXPAmountText;

	private GamePassTier gamePassTier;

	public void Initialize(GamePassesXpRewardInfo rewardInfo, GamePassTier gpt)
	{
	}

	public void OnSliderChange()
	{
	}

	public void OnInputFieldChange()
	{
	}

	public void UpdateXPData(int xpAmount)
	{
	}

	public void OnOkayPressed()
	{
	}

	private void UpdateBonusXpAmountText(int xpRewardAmount)
	{
	}
}
