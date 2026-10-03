using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class MVGroundState
{
	private MVMaterial groundMaterial;

	private const float groundDepth = 0.1f;

	private ObscuredBool grounded;

	private Vector3 groundNormal;

	private float gradientAngle;

	private Vector3 gradientDirection;

	public Action<GroundChange> OnGroundChange;

	public float GradientAngle => 0f;

	public float GroundDepth => 0f;

	public MVMaterial GroundMaterial => null;

	public bool Grounded => false;

	public Vector3 GroundNormal => default;

	public Vector3 ApplySlidingVelocity(Vector3 velocity, float density, MVInteractableBase interactableLocal)
	{
		return default;
	}

	public bool GroundTest(out MVControllerColliderHit groundHit, MvCharacterController controller, Vector3 velocity, bool sendCollData, float additionalGroundDepth = 0f)
	{
		groundHit = default;
		return false;
	}

	public bool Update(MvCharacterController controller, Vector3 velocity, float additionalGroundDepth = 0f)
	{
		return false;
	}

	public void UpdateGroundStateWithHitExternal(MvCharacterController controller, MVControllerColliderHit groundHit)
	{
	}

	private void UpdateGroundStateWithHit(MvCharacterController controller, bool foundGroundHit, MVControllerColliderHit groundHit)
	{
	}

	private void UpdateGroundData(MvCharacterController controller, bool foundGroundHit, MVControllerColliderHit groundHit)
	{
	}

	private static float GetGradientAngle(Vector3 gradientDirection)
	{
		return 0f;
	}

	private void UpdateGroundChange()
	{
	}

	private bool IsGroundedTest()
	{
		return false;
	}
}
