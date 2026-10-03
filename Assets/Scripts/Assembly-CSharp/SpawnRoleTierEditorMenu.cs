using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnRoleTierEditorMenu : MonoBehaviour
{
	[SerializeField]
	private Text currentTierNumberText;

	[SerializeField]
	private Text progressBarText;

	[SerializeField]
	private ProgressBar progressBar;

	[SerializeField]
	private SpawnRoleTierSettings tierSettingsPrefab;

	private int spawnRoleCost;

	private GamePassTier currentTier;

	private bool canSelectTier0;

	private UnityAction<GamePassTier> ChangeTierRequirement;

	public void Initialize(GamePassTier newTier, int newspawnRoleCost, UnityAction<GamePassTier> ChangeTierRequirement)
	{
	}

	public void UpdateSpawnRoleCost(int newspawnRoleCost)
	{
	}

	public void UpdateTier(GamePassTier newTier)
	{
	}

	public void SelectTier()
	{
	}

	private void OnTierSelected(GamePassTier newTier)
	{
	}
}
