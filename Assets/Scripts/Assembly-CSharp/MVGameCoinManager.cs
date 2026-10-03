using System;
using CodeStage.AntiCheat.ObscuredTypes;

public class MVGameCoinManager
{
	public delegate void OnActivationChangeDelegate(bool active);

	public delegate void OnGameCoinAmountChangeDelegate(int amount);

	private ObscuredFloat startTime;

	private ObscuredFloat interval;

	private ObscuredInt intervalAmount;

	private int currentBoostMultiplier;

	private ObscuredBool boostEnabled;

	private ObscuredFloat boostedInterval;

	private ObscuredInt gameCoinPickupValue;

	private ObscuredInt gameCoins;

	private ObscuredBool isActive;

	private ObscuredInt totalPurchaseAmount;

	public OnActivationChangeDelegate OnActivationChange;

	public OnGameCoinAmountChangeDelegate OnGameCoinAmountChange;

	public Action<bool> BoostStateChanged;

	public int GameCoinAmount => 0;

	public int TotalPurchaseAmount => 0;

	public bool Active => false;

	public bool BoostEnabled => false;

	public void OnGameBoostChanged(bool boostEnabled)
	{
	}

	public void Update(MVNetworkGame game)
	{
	}

	private int GetBoostedGameCoinCount(int defaultAmount)
	{
		return 0;
	}

	public void Reset(MVNetworkGame game)
	{
	}

	public void GameCoinCollect()
	{
	}

	public void GameCoinChestCollect(int amount)
	{
	}

	public bool Consume(GameCoinLogic gameCoinLogic)
	{
		return false;
	}

	public void ReportPurchaseAmountInEditor(int amount)
	{
	}

	public void ReportPickupChangeInEditor()
	{
	}

	private void Evaluate()
	{
	}

	private void HandleActivationChange(bool active)
	{
	}

	private void LateInitialize()
	{
	}

	private void Initialize()
	{
	}

	private void OnGameCoinBoostChanged()
	{
	}
}
