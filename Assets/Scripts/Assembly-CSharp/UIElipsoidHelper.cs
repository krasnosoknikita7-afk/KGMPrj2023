using UnityEngine;

public class UIElipsoidHelper
{
	private readonly Matrix4x4 elipsoidSpaceToWorld;

	private readonly Matrix4x4 worldToElipsoidSpace;

	private readonly float width;

	private readonly float height;

	public bool IsIdentical(float width, float height)
	{
		return false;
	}

	public UIElipsoidHelper(float width, float height)
	{
	}

	public Vector3 Clamp(Vector3 deltaDir)
	{
		return default;
	}

	public float NormalizedDistance(Vector3 deltaDir)
	{
		return 0f;
	}
}
