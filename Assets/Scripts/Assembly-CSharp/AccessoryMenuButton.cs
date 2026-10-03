using UnityEngine;
using UnityEngine.UI;

public class AccessoryMenuButton : MonoBehaviour
{
	[SerializeField]
	private GameObject redDotNotification;

	[SerializeField]
	private AccessoryShinyButton shineEffect;

	[SerializeField]
	private Text redDotNotificationText;

	[SerializeField]
	private AccessoryPreviewPopup accessoryPreviewPopup;

	private bool playerReady;

	private void Start()
	{
	}

	private void OnJoinChanged(MVJoinState joinState)
	{
	}

	private void OnEnable()
	{
	}

	private void PlayerReady()
	{
	}

	private void OnAccessoryDataReady()
	{
	}

	private void CalculateShouldShowAccessoryPopup()
	{
	}

	private void CalculateShouldShowHighlightIcon()
	{
	}

	private void CalculateShouldShowBundleAd()
	{
	}
}
