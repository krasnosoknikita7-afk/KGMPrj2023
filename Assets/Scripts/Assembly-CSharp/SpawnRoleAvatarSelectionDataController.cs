using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SpawnRoleAvatarSelectionDataController : MonoBehaviour, IHandleSpawnRoleAvatarSelectionData, IEventSystemHandler
{
	private List<SpawnRoleAvatarSelectionData> avatarSelectionDataList;

	private UnityAction<List<SpawnRoleAvatarSelectionData>> onDataRecieved;

	public void TryGetSpawnRoleAvatarSelectionData(UnityAction<List<SpawnRoleAvatarSelectionData>> onDataReady)
	{
	}

	private void OnDestroy()
	{
	}

	private void GameOnReceivedAvatarBodiesFromQuery(object sender, ReceivedItemFromQueryEventArgs e)
	{
	}
}
