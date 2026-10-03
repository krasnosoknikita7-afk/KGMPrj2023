using System.Collections.Generic;
using MV.Common;
using UnityEngine.Events;

public class FriendList
{
	public delegate void OnFriendListUpdatedDelegate();

	public delegate void OnFriendRequestUpdated(Friend friend);

	public OnFriendListUpdatedDelegate OnFriendListUpdated;

	public OnFriendRequestUpdated OnFriendRequestAccepted;

	public UnityAction OnFriendRequestReceived;

	public UnityAction<int> OnPendingCountChanged;

	private Dictionary<int, Friend> friends;

	private Dictionary<int, Friend> pending;

	private List<int> pendingNotifications;

	public Dictionary<int, Friend> Friends => null;

	public Dictionary<int, Friend> Pending => null;

	public List<int> PendingProfileIds => null;

	public Friend this[int friendID] => null;

	private void OnPlayersLoaded()
	{
	}

	public void AddFriend(int friendID, int profileID, int friendProfileID, FriendStatus status)
	{
	}

	public void UpdateFriend(int friendID, int profileID, FriendStatus status)
	{
	}

	public bool IsFriend(int profileID)
	{
		return false;
	}

	public Friend GetFriendByProfileID(int profileID)
	{
		return null;
	}

	public Dictionary<int, MVPlayer> GetOnlineFriends()
	{
		return null;
	}

	private void RemoveFromPendingByProfileID(int profileID)
	{
	}
}
