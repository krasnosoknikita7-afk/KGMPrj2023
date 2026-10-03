using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleAvatarSelectionMenu : MonoBehaviour
{
	[SerializeField]
	private RectTransform avatarElementContainer;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private Scrollbar scrollBar;

	[SerializeField]
	private SpawnRoleAvatarSelectionElement avatarSelectionElementPrefab;

	[SerializeField]
	private int maxSelectionElementsOnScreen;

	private int spawnRoleId;

	private int currentSelectionStartIndex;

	private List<SpawnRoleAvatarSelectionData> avatarSelectionDataList;

	private List<SpawnRoleAvatarSelectionElement> selectionElements;

	public void Initialize(int spawnRoleId)
	{
	}

	public void OnScrollValueChanged()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSpawnRoleAvatarDataRecieved(List<SpawnRoleAvatarSelectionData> avatarSelectionDataList)
	{
	}

	private void UpdateShownElements()
	{
	}

	private bool IsIndexWithinBounds(int index)
	{
		return false;
	}

	private void ShowElements(int startElementIndex)
	{
	}

	private void HideElements(int previousStartElement, int amountOfElements, int newStartElement)
	{
	}

	private void AddSelectionElement(int index)
	{
	}

	private void OnAvatarSelected(int avatarId)
	{
	}
}
