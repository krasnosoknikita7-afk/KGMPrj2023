using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AvatarSelectionController : MonoBehaviour, IAvatarSlotClicked, IEventSystemHandler
{
	[SerializeField]
	private AvatarSelectionSlot avatarSelectionSlotPrefab;

	[SerializeField]
	private RectTransform avatarSelectionContentRoot;

	[SerializeField]
	private SellAvatarController sellAvatarPrefab;

	[SerializeField]
	private GameObject publishAvatarGO;

	private int currSelectedSlot;

	private readonly Dictionary<int, AvatarSelectionSlot> avatarSlots;

	private static AvatarSelectionController instance;

	private AvatarEditModeBodyController avatarBodyController;

	public static int CurrentlySelectedSlotIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Initialize(AvatarEditModeBodyController bodyController, EditorStateMachine esm)
	{
	}

	public void Destroy()
	{
	}

	public void ResetCurrentAvatar()
	{
	}

	public void AvatarSlotClicked(int slotIndex)
	{
	}

	public void SetStateToRoam()
	{
	}

	private void OnPicUpdateForPrevAvatar(int index, Texture2D image)
	{
	}

	public void SellCurrentAvatar()
	{
	}

	public void TakeScreenshotForProfile()
	{
	}

	public void SetToNextAnimation()
	{
	}

	public void OpenAvatarShop()
	{
	}

	private void OnPictureTakenCallback(int index, Texture2D image)
	{
	}
}
