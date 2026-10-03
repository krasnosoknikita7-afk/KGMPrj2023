using System.Collections.Generic;

public class GoldRewardNotification : Notification
{
	private NotificationLifetime lifeTime;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	public void RewardClicked()
	{
	}
}
