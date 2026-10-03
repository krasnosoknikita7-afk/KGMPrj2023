using UnityEngine;

public class AvatarShieldDecay : MonoBehaviour
{
	private float decayTime;

	private const float decayCooldown = 1f;

	private MVRuntimeDataVariableClampedFloat shield;

	private const float decayAmount = 15f;

	private float accumulatedShieldDecay;

	private float updateValueTime;

	private const float updateValueCooldown = 0.5f;

	public void Init(MVRuntimeDataVariableClampedFloat shield)
	{
	}

	private void Update()
	{
	}

	public void ResetDecayTimer()
	{
	}
}
