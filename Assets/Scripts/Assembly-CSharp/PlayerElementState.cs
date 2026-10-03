using UnityEngine;
using UnityEngine.UI;

public class PlayerElementState : MonoBehaviour
{
	[SerializeField]
	private Button requestFriendship;

	[SerializeField]
	private Button pendingFriendship;

	[SerializeField]
	private Button acceptFriendRequest;

	[SerializeField]
	private Button cancel;

	[SerializeField]
	private Button manageUserButton;

	[SerializeField]
	private AdminToolController adminToolsPrefab;

	[SerializeField]
	private OwnerToolController ownerToolsPrefab;

	[SerializeField]
	private Text playerName;

	public void Initialize(MVPlayer player, Friend friend)
	{
	}

	public void OpenUserManagement()
	{
	}

	private void SetButtonVisibility(MVPlayer player, Friend friend)
	{
	}

	private void SetupButtons(MVPlayer player, Friend friend)
	{
	}

	private void ValidateFriendRequest()
	{
	}
}
