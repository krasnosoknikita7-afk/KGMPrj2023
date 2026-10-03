using System.Collections.Generic;
using MV.Common;
using MV.WorldObject.GamePassSystem.GamePassEarnings;
using UnityEngine;
using UnityEngine.UI;

public class GameEarningsMenu : MonoBehaviour
{
	[SerializeField]
	private Text totalEarningsAmount;

	[SerializeField]
	private Text boostEarningPercentage;

	[SerializeField]
	private Text tier1EarningPercentage;

	[SerializeField]
	private Text tier2EarningPercentage;

	[SerializeField]
	private Text tier3EarningPercentage;

	[SerializeField]
	private Image boostCircularImage;

	[SerializeField]
	private Image tier1CircularImage;

	[SerializeField]
	private Image tier2CircularImage;

	[SerializeField]
	private Image tier3CircularImage;

	[SerializeField]
	private Text displayedEarningsDescriptionText;

	[SerializeField]
	private Text displayedEarningsAmountText;

	[SerializeField]
	private GameObject displayedSmallGoldIcon;

	[SerializeField]
	private GameObject displayedLargeGoldIcon;

	[SerializeField]
	private List<RectTransform> transformsToExpand;

	[SerializeField]
	private List<RectTransform> pieChartsToEnlargen;

	[SerializeField]
	private float widthExpandAmount;

	[SerializeField]
	private float pieChartSizeIncreasePercentage;

	private List<int> tierEarnings;

	private List<float> originalWidthPositionsList;

	private List<float> originalSizeList;

	private float interpolationStartTime;

	private int currentFocusedEarning;

	private const float outlineInterpolationSpeed = 2f;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void SetUpWaitingForProjectEarningsReportUI()
	{
	}

	private void OnProjectEarningsUpdatedCallback(ProjectEarningsReport projectEarningsReport)
	{
	}

	private void UpdateEarningsData(ProjectEarningsReport projectEarningsReport)
	{
	}

	private int GetTotalEarnings(ProjectEarningsReport projectEarningsReport)
	{
		return 0;
	}

	private int GetTotalBoostEarnings(ProjectEarningsReport projectEarningsReport)
	{
		return 0;
	}

	private int GetTierEarnings(ProjectEarningsReport projectEarningsReport, GamePassTier tier)
	{
		return 0;
	}

	private void UpdateEarningsText(int boostersEarnings, int tier1Earnings, int tier2Earnings, int tier3Earnings, int totalEarnings)
	{
	}

	private int GetPercentage(int earnings, int totalEarnings)
	{
		return 0;
	}

	private bool IsPercentageWhole(int tierEarnings, int totalEarnings)
	{
		return false;
	}

	private void UpdateEarningPieChart(int boostersEarnings, int tier1Earnings, int tier2Earnings, int tier3Earnings, int totalEarnings)
	{
	}

	private void UpdateDisplayedText()
	{
	}

	private void ResetHighlightEffects()
	{
	}

	public void OnHighlightEarning(int earningEntered)
	{
	}

	public void OnStopHighlightEarning(int earningExited)
	{
	}
}
