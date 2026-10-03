using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class AvatarAccessoryEquipPopup : MonoBehaviour, IEventSystemHandler
{
	[SerializeField]
	private StreamedSpriteToImageManual preview;

	[SerializeField]
	private AccessoryItemBackground itemBackground;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private GameObject emptyFrame;

	private UnityAction resultCallback;

	private AccessoryDataClient accessoryDataClient;

	private float accessoryOffset;

	private float accessoryScale;

	public void Initialize(UnityAction resultCallback, string previewImageUrl, AccessoryDataClient accessoryData, float accessoryOffset, float accessoryScale)
	{
	}

	public void Equip()
	{
	}

	public void DontEquip()
	{
	}

	private void OnPreviewImageDownLoaded()
	{
	}
}
