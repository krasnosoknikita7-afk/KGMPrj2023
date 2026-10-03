public class DynamicLODDistance
{
	private float volumePercentChangePrSecond;

	private int prevTick;

	private float currentRadius;

	private readonly float maxVolume;

	public readonly float minRadius;

	public readonly float maxRadius;

	public readonly int maxNumObjects;

	public float CurrentRadius => 0f;

	public DynamicLODDistance(float minRadius, float maxRadius, int maxNumObjects)
	{
	}

	public void Update(int numObjects)
	{
	}

	public float GetDeltaTime()
	{
		return 0f;
	}

	private static float RadiusToVolume(float radius)
	{
		return 0f;
	}

	private static float VolumeToRadius(float volume)
	{
		return 0f;
	}

	private float GetTargetVolume(float numObjectsMaxObjectsRatio)
	{
		return 0f;
	}

	public static void Test()
	{
	}

	private static void TickTest()
	{
	}

	private static void UpdateTest()
	{
	}

	private static void MathTest()
	{
	}
}
