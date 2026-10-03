using UnityEngine;
using UnityEngine.UI;

public class TeamRequirementPanel : NotificationRequirementPanel
{
	[SerializeField]
	private Image redNotificationIcon;

	[SerializeField]
	private Image greenNotificationIcon;

	[SerializeField]
	private Image blueNotificationIcon;

	[SerializeField]
	private Image yellowNotificationIcon;

	private Image activeNotificationIcon;

	public override void OnToggleEnabled(object team, Sprite checkmarkSprite, bool enabled)
	{
	}
}
