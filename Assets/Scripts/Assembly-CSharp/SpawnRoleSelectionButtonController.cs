using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleSelectionButtonController : MonoBehaviour
{
	[SerializeField]
	private GameObject selectButton;

	[SerializeField]
	private GameObject buyTierButton;

	[SerializeField]
	private GameObject lockedTierButton;

	[SerializeField]
	private Text buyTierButtonText;

	[SerializeField]
	private Text lockedTierButtonText;

	[SerializeField]
	private GameObject FreeTryUI;

	private GamePassTier currentSpawnRoleGamePassTier;

	public void OnNewSelectedSpawnRole(GamePassTier spawnRoleTier)
	{
	}

	private void OnEnable()
	{
	}
}
