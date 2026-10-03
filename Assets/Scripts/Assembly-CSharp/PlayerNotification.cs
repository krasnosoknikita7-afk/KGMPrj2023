using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerNotification : Notification
{
	[SerializeField]
	protected Text NameLabel;

	[SerializeField]
	private Image BadgeImage;

	[SerializeField]
	private RectTransform PrestigiousPlayerFrame;

	[SerializeField]
	private RectTransform FriendPlayerFrame;

	private MVPlayer player;

	private Texture2D badgeTextureAsset;

	private const int PrestigiousLevelRequirement = 25;

	protected NotificationLifetime lifeTime;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void OnDestroy()
	{
	}

	private void BadgeCallback(UnityWebRequest www)
	{
	}
}
