using System;
using System.Collections.Generic;
using MV.WorldObject.GamePassSystem.GamePassEarnings;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.GameBoosterSettings.GameBoosterSettingTypes;
using UnityEngine;
using UnityEngine.UI;

public class BoostEditMenuItem : MonoBehaviour
{
	[Serializable]
	private struct BoosterDef
	{
		public BoostType type;

		public GameObject iconPrefab;
	}

	[SerializeField]
	private RectTransform boostTypeImageParent;

	[SerializeField]
	private Text boostDescription;

	[SerializeField]
	private Text goldPriceText;

	[SerializeField]
	private Text earningsAmountText;

	[SerializeField]
	private ToggleButtonAnimation activeToggleButton;

	[SerializeField]
	private BoostEditPopup boostEditPopupPrefab;

	[SerializeField]
	private BoostEditIntPopup boostEditIntPopupPrefab;

	[SerializeField]
	private BoostEditFloatPopup boostEditFloatPopupPrefab;

	[SerializeField]
	private List<BoosterDef> boosterList;

	private Boost boost;

	private GameBoosterSettingWithGoldSetting boosterSetting;

	private bool isActive;

	public void Initialize(Boost boost)
	{
	}

	public void UpdateEarningsText(ProjectEarningsReport projectEarningsReport)
	{
	}

	public void ShowEditPopup()
	{
	}

	public void OnActiveToggle()
	{
	}

	private int GetBoostEarning(ProjectEarningsReport projectEarningsReport)
	{
		return 0;
	}

	private void OnBoostSettingChange(object newValue)
	{
	}

	private void OnPriceSettingChanged(int newPrice)
	{
	}

	private void OnSubmitData()
	{
	}
}
