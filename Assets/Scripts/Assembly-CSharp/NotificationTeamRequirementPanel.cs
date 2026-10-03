using UnityEngine;
using UnityEngine.UI;

public class NotificationTeamRequirementPanel : NotificationRequirementPanel
{
	[SerializeField]
	private Image requirementImage;

	[SerializeField]
	private Sprite redNotificationIcon;

	[SerializeField]
	private Sprite greenNotificationIcon;

	[SerializeField]
	private Sprite blueNotificationIcon;

	[SerializeField]
	private Sprite yellowNotificationIcon;

	public override void OnToggleEnabled(object team, Sprite checkmarkSprite, bool enabled)
	{
	}
}
