using System;
using System.Collections.Generic;
using UnityEngine;

public class GameMeterHandler : MonoBehaviour
{
	[SerializeField]
	private List<GameMeterBase> gameMeters;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateValue()
	{
	}

	private void ConditionCountChanged(object sender, EventArgs args)
	{
	}

	private void OnGameStatUpdated(object sender, OnCounterTypeChangedArgs args)
	{
	}

	private void CounterChanged(object sender, OnCounterTypeChangedArgs args)
	{
	}
}
