using UnityEngine;

public class MVCharacterController3D : MvCharacterController
{
	public override void Move(Vector3 motion)
	{
	}

	public override MvCharacterController CloneToGameObject(GameObject targetGameObject, GameObject seat)
	{
		return null;
	}

	protected override Vector3 CollideAndSlide(Vector3 R3Vel, Vector3 R3Position)
	{
		return default;
	}

	protected override Vector3 GetNextVelocity(Vector3 ePoint, Vector3 eNewBasePoint, Vector3 eDestinationPoint, ref Vector3 slidePlaneNormal)
	{
		return default;
	}

	protected override Vector3 RecalcDirectionMoveAway(Vector3 ePos, Vector3 eDir, float distance, Vector3 ePoint)
	{
		return default;
	}

	protected override bool NoOverlapPosition(Vector3 R3Position, Vector3 R3Direction, ref Vector3 offset)
	{
		return false;
	}
}
