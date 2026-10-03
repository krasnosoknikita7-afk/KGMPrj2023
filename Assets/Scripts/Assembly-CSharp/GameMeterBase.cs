using System.Collections.Generic;
using GameMeterVisuals;
using UnityEngine;

public abstract class GameMeterBase : MonoBehaviour
{
	[SerializeField]
	protected List<GameMeterVisualEffect> gameMeterVisualEffects;

	protected float inActiveAlpha;

	protected bool meterActive;

	public abstract GameMeterType GameMeterType { get; }

	public bool MeterActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public abstract void Initialize();

	public abstract void SetShowGameMeter(bool show);

	public abstract void UpdateValue();

	public abstract void SetGameMeterVisibility();
}
