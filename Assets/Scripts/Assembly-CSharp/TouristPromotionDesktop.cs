using UnityEngine;
using UnityEngine.UI;

public class TouristPromotionDesktop : TouristPromotion
{
	[SerializeField]
	private GameObject visitKogamaPopupPrefab;

	[SerializeField]
	private GameObject redirectButton;

	[SerializeField]
	private Text redirectButtonURLText;

	[SerializeField]
	private GameObject goToKogamaPopupPrefab;

	[SerializeField]
	private GameObject signupButton;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	protected override void Start()
	{
	}

	public void SignupCallback()
	{
	}

	public void LoginCallback()
	{
	}

	public void KogamaRedirect()
	{
	}

	public override void OnContinueClicked()
	{
	}

	private void ShowGoToKogamaPopup()
	{
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}

	private void OnDestroy()
	{
	}
}
