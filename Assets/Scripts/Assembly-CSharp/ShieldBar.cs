using UnityEngine;

public class ShieldBar : MonoBehaviour
{
	public Transform shieldPivot;

	private const float maxShieldValue = 100f;

	private float interpolateTowardsShield;

	private float previousShieldValue;

	private float elapsedInterpolationTime;

	public float Shield
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Update()
	{
	}
}
