using MV.Common;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ModalPopupCreator : MonoBehaviour, IModalPopupCreator, IEventSystemHandler
{
	[SerializeField]
	private UIPushOption popupPushOption;

	[SerializeField]
	private ConfirmationPopup confirmationPopupPrefab;

	[SerializeField]
	private NotificationPopup notificationPopupPrefab;

	[SerializeField]
	private PleaseWaitPopup waitPopupPrefab;

	public NotificationPopup Create(string text, string header = "")
	{
		return null;
	}

	public ConfirmationPopup Create(string text, UnityAction<bool, ConfirmationPopup> resultCallback, string header = "")
	{
		return null;
	}

	public PleaseWaitPopup Create()
	{
		return null;
	}

	public void Create(MVPurchaseReturnCode returnCode, int priceGold)
	{
	}

	public void CreateErrorNotificationPopup(string error, string header = "Error")
	{
	}

	private static void OnGoldPurchaseDialogResult(bool result, ConfirmationPopup confirmationPopup)
	{
	}
}
