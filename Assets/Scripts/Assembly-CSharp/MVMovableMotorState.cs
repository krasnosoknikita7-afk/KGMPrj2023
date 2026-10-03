using UnityEngine;

public class MVMovableMotorState
{
	public bool Move(Vector3 velocity, MvCharacterController controller, float tolerance, MVGroundState groundState, out Vector3 movableVelocityVector)
	{
		movableVelocityVector = default;
		return false;
	}

	protected void CheckMoveables(MvCharacterController controller, float tolerance)
	{
	}
}
