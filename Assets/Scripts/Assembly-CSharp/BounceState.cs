using UnityEngine;

public class BounceState
{
	private const float maxHeight = 10f;

	private const float bounceMinVal = 1f;

	private const float bounceStrengthThres = 10f;

	private Vector3 bounceVelocity;

	private readonly MVInteractable interactable;

	private bool bounced;

	public bool Bounced => false;

	public BounceState(MVInteractable interactable)
	{
	}

	public Vector3 ApplyBounceVelocity(Vector3 velocity)
	{
		return default;
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}

	private void UpdateBounceState(MVControllerColliderHit mvControllerColliderHit)
	{
	}

	private static Vector3 GetOutVectorFromInVector(Vector3 normal, Vector3 inVector)
	{
		return default;
	}
}
