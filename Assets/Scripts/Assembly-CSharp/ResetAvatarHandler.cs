using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResetAvatarHandler : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private AvatarScreenShooter screenShooter;

	[SerializeField]
	private PleaseWaitPopup pleaseWaitPopupPrefab;

	[SerializeField]
	private GameObject invisibleBlocker;

	[SerializeField]
	private AvatarPreviewer previewer;

	[SerializeField]
	private RawImage fromImage;

	[SerializeField]
	private RawImage toImage;

	[SerializeField]
	private int previewDimensions;

	[SerializeField]
	private float defaultRotationSpeed;

	[SerializeField]
	private float rotationSensitivity;

	private float currentRotationSpeed;

	private Action OnReset;

	private MVBody avatarBody;

	private Transform avatarResetToTransform;

	private AvatarPreviewer fromPreviewer;

	private AvatarPreviewer toPreviewer;

	private const string mouseX = "Mouse X";

	private bool imagesReady;

	private bool isDown;

	public void ResetAvatar(MVBody currentBody, Action onReset)
	{
	}

	private void GetResetAvatarData(int id)
	{
	}

	private void GameOnReceivedItemFromQuery(object sender, ReceivedItemFromQueryEventArgs receivedItemFromQueryEventArgs)
	{
	}

	public void OnDrag(PointerEventData data)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnAcceptReset()
	{
	}
}
