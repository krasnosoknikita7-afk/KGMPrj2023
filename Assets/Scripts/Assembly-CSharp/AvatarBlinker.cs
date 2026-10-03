using UnityEngine;

public class AvatarBlinker : BlinkerBase
{
	public Color blinkDamageColor;

	public Color blinkHealthBoostColor;

	public Color blinkPoisonColor;

	public Color blinkFrozenColor;

	public Color blinkHealingColor;

	public Color blinkShieldColor;

	public Color blinkLethalColor;

	private float previousBlinkHealth;

	private float previousBlinkShield;

	private void Awake()
	{
	}

	public void EnableBlinking()
	{
	}

	public void DisableBlinking()
	{
	}

	public void HealthChangeHandler(object v)
	{
	}

	public void UpdateBlinking()
	{
	}

	public override void LateUpdate()
	{
	}

	public void ShieldChangeHandler(object v)
	{
	}

	private void HandleDamageBlinking(float previousValue, float currentValue, BlinkType blinkType)
	{
	}

	public void SetPreviousHealth(float health)
	{
	}

	public void SetPreviousShield(float shield)
	{
	}
}
