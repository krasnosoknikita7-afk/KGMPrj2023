using UnityEngine;

public class HealthBar : MonoBehaviour
{
	public Transform healthPivot;

	public Transform oxygenPivot;

	public float MaxHealth { get; set; }

	public float Health
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Oxygen
	{
		set
		{
		}
	}

	private void SetScaleFromHealth(float value)
	{
	}
}
