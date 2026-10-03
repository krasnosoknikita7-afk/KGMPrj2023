using UnityEngine;

public class AdvancedGhostMotor : MVRigidBody
{
	private float baseHeight;

	private Transform targetTransform;

	private float ghostFriction;

	private Vector3 prevLocalPosition;

	private float minDeltaPos;

	private Vector3 velocity;

	private float speedSmoothing;

	private MVInteractableBase interactable;

	private SmoothPhysicsMovement smoothPhysicsMovement;

	public override bool Grounded => false;

	public override Vector3 Velocity => default;

	public override bool IsMovementLocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 MoveDirection { get; set; }

	protected override void SuspendImpactDamage()
	{
	}

	public void Init(GameObject ghostBehaviour, MVInteractableBase interactable, CullingSubscriberBase cullingSubscriberBase)
	{
	}

	public void FixedUpdateFunction()
	{
	}

	public void FixedUpdateRotation()
	{
	}

	public void FrameUpdate()
	{
	}

	public void Reset(Vector3 velocity)
	{
	}

	private void UpdateVelocity()
	{
	}

	private void Move(Vector3 velocity)
	{
	}

	private Vector3 ApplyInputVelocityChange()
	{
		return default;
	}

	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default;
	}
}
