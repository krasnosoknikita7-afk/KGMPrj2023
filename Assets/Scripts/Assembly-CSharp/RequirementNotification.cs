using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class RequirementNotification : Notification
{
	[SerializeField]
	private Sprite OnSprite;

	[SerializeField]
	private Sprite OffSprite;

	[SerializeField]
	private RectTransform Layout;

	[SerializeField]
	private NotificationRequirementPanel LevelPanel;

	[SerializeField]
	private NotificationRequirementPanel GamecoinPanel;

	[SerializeField]
	private NotificationRequirementPanel StarPanel;

	[SerializeField]
	private NotificationRequirementPanel TeamPanel;

	[SerializeField]
	private NotificationRequirementPanel GameTierPanel;

	private List<GameObject> PanelsToDestroy;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void ShowGameCoinRequirement(int gameCoins)
	{
	}

	private void ShowStarRequirement(int stars)
	{
	}

	private void ShowTeamRequirement(MVTeam team)
	{
	}

	private void ShowLevelRequirement(int level)
	{
	}

	private void ShowGameTierRequirement(GamePassTier tier)
	{
	}

	private GameObject InstantiatePanel(NotificationRequirementPanel panel)
	{
		return null;
	}
}
