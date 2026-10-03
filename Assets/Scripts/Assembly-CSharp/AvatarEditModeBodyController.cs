using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AvatarEditModeBodyController : MonoBehaviour, IAvatarEditAnimationState, IEventSystemHandler
{
	private List<MVBody> bodies;

	private MVSpawnPointRed bodySpawnPoint;

	private Vector3 displayPos;

	private Quaternion displayRotation;

	private Vector3 hidePos;

	private int currentBodyIndex;

	private AvatarRepositoryItem purchasingItem;

	private string currentActionSuccessMessage;

	private bool playingPurchaseSoundAfterScreenshot;

	[SerializeField]
	public AvatarPictureTakerUGUI pictureTaker;

	[SerializeField]
	private NotificationPopup notificationPopup;

	[SerializeField]
	private PleaseWaitPopup pleaseWaitPopupPrefab;

	[SerializeField]
	private UploadAvatarScreenshotHandler uploadAvatarScreenshotHandler;

	[SerializeField]
	private ResetAvatarHandler resetAvatarHandler;

	private List<string> animations;

	private int currentAnimationIndex;

	public Action<int, Texture2D> Picture2DTakenCallback;

	private GameObject publishAvatarBtn;

	public static CloudyThemeBase Theme;

	public MVBody CurrentBody => null;

	public Vector3 DisplayPos => default;

	public void Initialize()
	{
	}

	public void SetPublishAvatarGO(GameObject publishAvatarGO)
	{
	}

	public void ResetCurrentBody()
	{
	}

	private void ExecuteReset()
	{
	}

	private void ResetCallback(object sender, InitializedGameQueryDataEventArgs e)
	{
	}

	public void SetCurrentBodyByWoId(int woId)
	{
	}

	public void SetCurrentBody(int index)
	{
	}

	private void SetPublishAvatarButtonActive()
	{
	}

	public void CaptureScreenshotForBody(int index, Action<int, Texture2D> OnPictureTaken)
	{
	}

	public void CaptureScreenshotsForAllAvatars(Action<int, Texture2D> OnPictureTaken)
	{
	}

	private void GenerateIconForBody(int index)
	{
	}

	public void TakeScreenshot()
	{
	}

	public void PurchaseAvatar(AvatarRepositoryItem item)
	{
	}

	private void OnPurchaseAvatarConfirmation(bool confirmed, ConfirmationPopup confirmationPopup)
	{
	}

	private void OnProductPurchaseAvatarResponse(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void InitializedPurchasedAvatar(object sender, InitializedGameQueryDataEventArgs e)
	{
	}

	private void OnActiveAvatarSetAfterPurchase()
	{
	}

	public void SellCurrentAvatar(SellAvatarController avatarSeller)
	{
	}

	private void ScreenShotCallback(Texture2D screenshotTex, string successMessage)
	{
	}

	private void UploadedImageData()
	{
	}

	private void MVNetworGame_ScreenshotUploadedHandler(object sender, ScreenshotUploadedEventArgs e)
	{
	}

	public void SetToNextAnimation()
	{
	}

	public void Set(string animation)
	{
	}
}
