using System;
using System.Collections.Generic;

public class BoostController
{
	public Action BoostCountChanged;

	private static readonly Dictionary<BoostType, Boost> boosts;

	private Dictionary<BoostType, Action> onBoostTypeUpdate;

	public List<BoostType> boostPriorityList;

	private Dictionary<BoostType, Boost> activeBoosts;

	private List<Boost> removeList;

	public void ActivateBoost(BoostType type)
	{
	}

	public void RemoveAllBoosts()
	{
	}

	private void BoostUpdated(BoostType type)
	{
	}

	public void AllowBoost(BoostType boost, bool allowed)
	{
	}

	public bool HasAvailableBoosts()
	{
		return false;
	}

	public void SubscribeToBoostChanged(BoostType type, Action callback)
	{
	}

	public void UnSubscribeToBoostChanged(BoostType type, Action callback)
	{
	}

	public bool IsBoostActive(BoostType type)
	{
		return false;
	}

	public Dictionary<BoostType, Boost>.ValueCollection GetAllBoosts()
	{
		return null;
	}

	public Dictionary<BoostType, Boost>.ValueCollection GetActiveBoosts()
	{
		return null;
	}

	public bool TryGetActiveBoost(BoostType type, out Boost boost)
	{
		boost = null;
		return false;
	}

	public bool TryGetBoost(BoostType type, out Boost boost)
	{
		boost = null;
		return false;
	}
}
