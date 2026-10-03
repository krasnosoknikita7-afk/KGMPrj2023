using UnityEngine;

public class AvatarCameraDistTransparency
{
	private Vector3 camMoveTowardsOffset;

	private float fadeStartDistance;

	private float fadeEndDistance;

	public float fadeStartBase;

	public float fadeEndBase;

	private float prevDist;

	private const float mininumDistanceRequired = 0.01f;

	public AvatarCameraDistTransparency(Vector3 camMoveTowardsOffset, float fadeStartDistance, float fadeEndDistance)
	{
	}

	public void SetScaleFadeDistance(float scale)
	{
	}

	public void Update(MVAvatarLocal avatarLocal)
	{
	}
}
