using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Text playerName;

	[SerializeField]
	private Text rank;

	[SerializeField]
	private Text score;

	[SerializeField]
	private GameObject memberUI;

	[SerializeField]
	private Text memberRank;

	[SerializeField]
	private Image nonMemberUI;

	[SerializeField]
	private Button playerNameAndScoreButton;

	[SerializeField]
	private List<Image> backgrounds;

	[SerializeField]
	private PlayerSocialPopup playerSocialPopupPrefab;

	[SerializeField]
	private Button dotsImage;

	[SerializeField]
	private Button incomingFriendRequestRedDot;

	[SerializeField]
	private Image underline;

	private string realPlayerName;

	private bool subscriber;

	private int profileId;

	public string PlayerName => null;

	public void Initialize(MVPlayer player, GameStatCounterType typeToDisplay, int scoreValue)
	{
	}

	public void OnPlayerClicked()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void UpdateScoreIndex()
	{
	}

	private void ActivateSubscriberUI(bool isFriend)
	{
	}
}
