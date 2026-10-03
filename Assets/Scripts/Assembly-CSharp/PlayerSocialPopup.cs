using UnityEngine;
using UnityEngine.UI;

public class PlayerSocialPopup : MonoBehaviour
{
	[SerializeField]
	private Text playerName;

	[SerializeField]
	private GameObject subscriberFrame;

	[SerializeField]
	private GameObject viewProfileButton;

	[SerializeField]
	private GameObject addFriendButton;

	[SerializeField]
	private GameObject pendingFriendship;

	[SerializeField]
	private GameObject cancel;

	[SerializeField]
	private GameObject acceptFriendRequest;

	[SerializeField]
	private GameObject friendButtonsGameObject;

	[SerializeField]
	private GameObject isFriendTextObject;

	[SerializeField]
	private Button manageUserButton;

	[SerializeField]
	private AdminToolController adminToolsPrefab;

	[SerializeField]
	private OwnerToolController ownerToolsPrefab;

	private int profileId;

	private Friend friend;

	public void Initialize(int remotePlayerProfileId, string name, bool isSubscriber)
	{
	}

	public void OnAcceptFriendClicked()
	{
	}

	public void OnFriendRequestCanceled()
	{
	}

	public void OnAddFriendClicked()
	{
	}

	public void OnViewProfileClicked()
	{
	}

	public void OnOpenAdminController()
	{
	}

	private void FriendRequestReceived()
	{
	}

	private void PendingCountChanged(int count)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetupFriendButtons()
	{
	}

	private void PostErrorPopup(string error)
	{
	}

	private bool ValidateFriendRequest(ref string error)
	{
		return false;
	}
}
