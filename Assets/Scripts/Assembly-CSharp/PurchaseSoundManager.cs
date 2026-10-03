using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PurchaseSoundManager : MonoBehaviour, IPurchaseSoundManager, IEventSystemHandler
{
	[SerializeField]
	private AudioSource purchaseSound;

	private bool surpressSound;

	private void Start()
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	public void SurpressSoundOnce()
	{
	}

	public void PlayPurchaseSound()
	{
	}
}
