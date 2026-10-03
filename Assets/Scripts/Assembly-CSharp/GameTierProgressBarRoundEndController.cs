using UnityEngine;

public class GameTierProgressBarRoundEndController : MonoBehaviour
{
	[SerializeField]
	private GameTierProgressBar tierProgressBar;

	[SerializeField]
	private GameTierProgressBarGainEffectController gainEffectController;

	[SerializeField]
	private GameObject inGameUIContent;

	private bool hasRoundEnded;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnRoundEnd(IWinningCondition winningCondition)
	{
	}
}
