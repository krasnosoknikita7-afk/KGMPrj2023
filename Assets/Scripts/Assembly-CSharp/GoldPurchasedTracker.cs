using UnityEngine;

public class GoldPurchasedTracker : MonoBehaviour
{
	private int goldDeltaExpected;

	private int currentGold;

	private int goldGainedTotal;

	private const string goldPendingUpdate = "GoldPendingUpdate";

	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public void StartGoldPurchasePendingUpdate(int currentGold, int goldDelta)
	{
	}

	public void GoldPendingUpdate()
	{
	}

	private void GoldUpdatedCallback()
	{
	}
}
