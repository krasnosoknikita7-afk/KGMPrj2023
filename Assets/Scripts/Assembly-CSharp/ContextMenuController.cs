using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ContextMenuController : MonoBehaviour, IHandlePointerDownOnContextMenuButton, IEventSystemHandler
{
	private int woID;

	private EditorStateMachine editorStateMachine;

	private bool rightClickGizmoSelect;

	private MVWorldObjectClient selectedWorldObject;

	private ContextMenu currentContextMenu;

	[SerializeField]
	private ContextMenu contextMenuPrefab;

	[SerializeField]
	private SettingsFactory settingsFactory;

	public bool MouseDown => false;

	public void Initialize(EditorStateMachine editorStateMachine)
	{
	}

	public void ShowContextMenu(int woID, Vector3 worldPos)
	{
	}

	private void ShowInfoDialog()
	{
	}

	private bool IsPendingPrototypeSelected()
	{
		return false;
	}

	private void AddMenuButtonForFlag(InteractionFlags flag, string buttonText, UnityAction onClickCallback)
	{
	}

	private void AddMenuButtonForFlag(InteractionFlags flag, string buttonText, UnityAction onClickCallback, Func<bool> canHaveButtonCheck)
	{
	}

	public void ShowContextMenuLink(int linkID, bool isObjectLink, Vector3 worldPos)
	{
	}

	public void PopGizmos()
	{
	}

	private void DeleteLink(int linkID, bool isObjectLink)
	{
	}

	private void ShowStarsDialog()
	{
	}

	private void ShowGameRankDialog()
	{
	}

	private void ShowGamePointsDialog()
	{
	}

	private void ShowMinorGamePointsDialog()
	{
	}

	private void ShowRespawnDialog()
	{
	}

	private void ShowTeamDialog()
	{
	}

	private void ShowGameCoinsDialog()
	{
	}

	private void ShowLevelsDialog()
	{
	}

	private void ShowRewardedAdDialog()
	{
	}

	private void ShowSettingsDialog()
	{
	}

	private void ShowSoundsDialog()
	{
	}

	private void ShowGlobalSoundsDialog()
	{
	}

	private void EnterCubeEdit()
	{
	}

	private void ShowChangeScaleDialog()
	{
	}

	private void ResetLogic()
	{
	}

	private void Clone()
	{
	}

	private void CloneRoot()
	{
	}

	private void AddToInventory()
	{
	}

	private void EnterPlay()
	{
	}

	private void OnClosedStandaloneError(bool confirmed, ConfirmationPopup popup)
	{
	}

	private void ItemImageUploaded(int woId)
	{
	}

	private void OnFailedToAddItem()
	{
	}

	private void Delete()
	{
	}

	private bool CanClone()
	{
		return false;
	}

	private bool CanCloneRoot()
	{
		return false;
	}

	public void PointerIsDown()
	{
	}

	private void OnContextMenuPop()
	{
	}
}
