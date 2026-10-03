using UnityEngine;

public class GamePassesShowDetailsButton : MonoBehaviour
{
	[SerializeField]
	private GameObject disabledButton;

	[SerializeField]
	private GamePassesTextBubble OnActivatedToolTip;

	[SerializeField]
	private GamePassesShopDetails shopDetails;

	[SerializeField]
	private GameObject crystalPopup;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnProgressionUpdate()
	{
	}

	private void UpdateButtonVisibility()
	{
	}

	public void OnButtonPressed()
	{
	}

	public void OnDisabledButtonPressed()
	{
	}
}
