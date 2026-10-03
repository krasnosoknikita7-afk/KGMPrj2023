using System;

public class AccessoryAttacher
{
	private ConfirmationPopup attachConfirmationPopup;

	private MVBody avatarBody;

	private Action OnFinishedCallback;

	public void AttachAccessory(int streamingAssetsId, MVBody currentBody, float offset, float scale, Action OnFinishedCallback)
	{
	}

	private void Game_OnSetAvatarAccessorySlotResponseEquipHandler(bool setSlotSuccess)
	{
	}
}
