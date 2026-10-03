using UnityEngine;

public static class CollisionDetectionGlobalBuffers
{
	private const int MAX_BUFFER_SIZE = 128;

	public static readonly RaycastHit[] rayHitBuffer;

	public static readonly Collider[] colliderBuffer;
}
