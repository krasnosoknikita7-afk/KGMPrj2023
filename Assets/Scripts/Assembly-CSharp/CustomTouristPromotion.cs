using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CustomTouristPromotion : TouristPromotion
{
	[SerializeField]
	private GameObject adContinueButton;

	[SerializeField]
	private Image graphics;

	protected override void Start()
	{
	}

	private void StreamingAssetCallback(UnityWebRequest www)
	{
	}

	public void Continue()
	{
	}

	public void Signup()
	{
	}

	public void CustomRedirect()
	{
	}
}
