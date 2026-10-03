using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;

public static class MVPhysics
{
	private static ObscuredFloat gravity;

	public static PhysicalProperties airPhysicalProperties;

	public static ObscuredFloat Gravity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public static void Reset()
	{
	}

	public static float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return 0f;
	}

	public static float CalculateJumpForceFromVerticalVelocity(float velocity)
	{
		return 0f;
	}
}
