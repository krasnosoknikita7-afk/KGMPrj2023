using UnityEngine;

public class HamsterWheelBounceState
{
	private const float maxHeight = 10f;

	private const float minBounceVal = 4.5f;

	private const float bounceStrengthThres = 10f;

	private const float hamsterBallBouncyness = 0.6f;

	private readonly MVInteractableBase interactable;

	private Vector3 bounceVelocity;

	private bool bounced;

	public bool Bounced => false;

	public HamsterWheelBounceState(MVInteractableBase interactable)
	{
	}

	public Vector3 ApplyBounceVelocityMaterials(Vector3 velocity)
	{
		return default;
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}

	private void UpdateBounceStateMaterial(MVControllerColliderHit mvControllerColliderHit)
	{
	}

	private static Vector3 GetOutVectorFromInVector(Vector3 normal, Vector3 inVector)
	{
		return default;
	}
}
