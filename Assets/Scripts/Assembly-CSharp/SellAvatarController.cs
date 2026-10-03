using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class SellAvatarController : MonoBehaviour
{
	[SerializeField]
	private InputField nameField;

	[SerializeField]
	private Button removeButton;

	[SerializeField]
	private Text sellButtonText;

	[SerializeField]
	private AvatarScreenShooter screenShooter;

	private int woID;

	private MvAvatarMetaData metaData;

	private MVBody body;

	public void Initialize(int woID, MVBody currentBody)
	{
	}

	public void OnSellPressed()
	{
	}

	private void ScreenShotCallback(Texture2D texture, string successMessage)
	{
	}

	private void OnImageUploaded()
	{
	}

	private void OnAddToMarketplace(bool added)
	{
	}

	private void OnPop()
	{
	}

	private bool IsSelectedBodyValid()
	{
		return false;
	}

	public void OnRemovePressed()
	{
	}

	private void OnRemoveFromMarketplace(bool added)
	{
	}
}
