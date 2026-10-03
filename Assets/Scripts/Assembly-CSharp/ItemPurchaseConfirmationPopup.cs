using UnityEngine;
using UnityEngine.Events;

public class ItemPurchaseConfirmationPopup : MonoBehaviour
{
	private UnityAction<bool> resultCallback;

	public void Initialize(UnityAction<bool> resultCallback)
	{
	}

	public void AcceptPurchase()
	{
	}

	public void DeclinePurchase()
	{
	}
}
