using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GamePassesHighScoreElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Text userRankText;

	[SerializeField]
	private Text userNameText;

	[SerializeField]
	private Text userAmountOfGamePointText;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private GameObject topBorderGameObject;

	[SerializeField]
	private GameObject subscriberUI;

	[SerializeField]
	private Button buttonElement;

	[SerializeField]
	private PlayerSocialPopup playerSocialPopup;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private int profileId;

	private bool isLocalPlayerElement;

	private bool subscriber;

	public void Initialize(int userRank, string userName, int amountOfGamePoints, int profileID, bool isSubscriber)
	{
	}

	private void FriendRequestAccepted(Friend friend)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnClick()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void DeactivateTopBorder()
	{
	}
}
