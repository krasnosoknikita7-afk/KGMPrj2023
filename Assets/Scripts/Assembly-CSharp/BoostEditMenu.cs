using System.Collections.Generic;
using MV.WorldObject.GamePassSystem.GamePassEarnings;
using UnityEngine;

public class BoostEditMenu : MonoBehaviour
{
	[SerializeField]
	private BoostEditMenuItem boostPrefab;

	[SerializeField]
	private RectTransform boostItemsScrollRect;

	[SerializeField]
	private RectTransform boostItemsContent;

	private List<BoostEditMenuItem> boostItems;

	public void Start()
	{
	}

	private void UpdateEarningsData(ProjectEarningsReport projectEarningsReport)
	{
	}

	private void OnProjectEarningsUpdatedCallback(ProjectEarningsReport projectEarningsReport)
	{
	}

	private void OnDestroy()
	{
	}
}
