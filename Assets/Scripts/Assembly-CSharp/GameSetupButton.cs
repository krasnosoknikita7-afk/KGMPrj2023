using UnityEngine;

public class GameSetupButton : MonoBehaviour
{
	[SerializeField]
	private GamePassesTextBubble OnActivatedToolTip;

	[SerializeField]
	private GameSetupMenu gameSetupMenuPrefab;

	private bool isTiersActivated;

	public void ShowGameSetupMenu()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnProgressionUpdate()
	{
	}
}
