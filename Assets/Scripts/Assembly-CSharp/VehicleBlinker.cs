using UnityEngine;

public class VehicleBlinker : BlinkerBase
{
	[SerializeField]
	private Color blinkDamageColor;

	[SerializeField]
	private Color blinkHealingColor;

	[SerializeField]
	private Color blinkAboutToExpireColor;

	private void Awake()
	{
	}

	public void Init(MeshFilter[] meshFilters)
	{
	}
}
