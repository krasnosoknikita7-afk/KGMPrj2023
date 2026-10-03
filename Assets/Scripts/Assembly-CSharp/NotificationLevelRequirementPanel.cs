using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NotificationLevelRequirementPanel : NotificationRequirementPanel
{
	[SerializeField]
	private Image LevelImage;

	private Texture2D badgeTextureAsset;

	public override void OnToggleEnabled(object text, Sprite checkmarkSprite, bool enabled)
	{
	}

	private void OnDestroy()
	{
	}

	private void BadgeCallback(UnityWebRequest www)
	{
	}

	private Sprite GetBadgeSprite(Texture2D source)
	{
		return null;
	}
}
