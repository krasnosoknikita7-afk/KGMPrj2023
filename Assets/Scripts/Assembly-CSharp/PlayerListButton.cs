using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListButton : MonoBehaviour
{
	[SerializeField]
	private PlayerListsLayout playerListsPrefab;

	[SerializeField]
	private Button button;

	[SerializeField]
	private Text playersCount;

	[SerializeField]
	private Image notification;

	[SerializeField]
	private ColorStyleObject colorStyleObject;

	private GameObject currPlayerLists;

	private Dictionary<int, MVPlayer> prevPlayerListState;

	private bool useColorStyle;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayerListReady()
	{
	}

	private void PendingCountChanged(int pending)
	{
	}

	private void ViewNotification()
	{
	}

	public void CreatePlayerList()
	{
	}

	private void UpdateButton()
	{
	}

	private void UpdatePlayersCount()
	{
	}

	private void UpdateTeamColor()
	{
	}
}
