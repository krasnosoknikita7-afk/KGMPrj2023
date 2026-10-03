using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class MvCharacterController : MonoBehaviour
{
	private struct NoCollisionData
	{
		private Vector3 position;

		private bool valid;

		public Vector3 Position => default;

		public bool Valid => false;

		public NoCollisionData(Vector3 pos, bool val)
		{
			position = default;
			valid = false;
		}
	}

	private const int maxRecursions = 7;

	private const float unitsPerMeter = 100f;

	private const float unitScale = 1f;

	protected const float veryCloseDistance = 0.005f;

	private const float collisionMaxAngle = 89.95f;

	private static int layerMask;

	private bool sendCollisionData;

	protected Vector3 center;

	protected Vector3 elipsoidRadius;

	protected int collisionRecursionDepth;

	private float offsetFactor;

	private float offsetBase;

	public Vector3 centerBase;

	public Vector3 radiusBase;

	public HashSet<int> IgnoreWoIds;

	public Action<MVControllerColliderHit> OnControllerColliderHit;

	public bool IsGrounded { get; set; }

	public Vector3 Velocity { get; set; }

	public float Radius => 0f;

	public float Height => 0f;

	public Vector3 Center => default;

	public abstract MvCharacterController CloneToGameObject(GameObject targetGameObject, GameObject seat);

	public abstract void Move(Vector3 motion);

	protected abstract Vector3 GetNextVelocity(Vector3 ePoint, Vector3 eNewBasePoint, Vector3 eDestinationPoint, ref Vector3 slidePlaneNormal);

	protected abstract bool NoOverlapPosition(Vector3 R3Position, Vector3 R3Direction, ref Vector3 offset);

	protected abstract Vector3 RecalcDirectionMoveAway(Vector3 ePos, Vector3 eDir, float distance, Vector3 ePoint);

	protected void Awake()
	{
	}

	public void Init(float radius, float height, Vector3 center)
	{
	}

	public void SetScale(float scale)
	{
	}

	public void Move(Vector3 motion, bool sendCollisionData)
	{
	}

	public bool CheckOverLap()
	{
		return false;
	}

	public List<MVOverlapResult> GetOverlappingObjects()
	{
		return null;
	}

	public Vector3 GetGradientDirection(VoxelHit elipsoidHit)
	{
		return default;
	}

	public bool TestWithOutSliding(float distance, Vector3 direction, Vector3 motion, out MVControllerColliderHit colliderHit)
	{
		colliderHit = default;
		return false;
	}

	protected abstract Vector3 CollideAndSlide(Vector3 R3Vel, Vector3 R3Position);

	protected Vector3 CollideWithWorld(ref Vector3 ePos, ref Vector3 eVel, ref bool foundValidPosition)
	{
		return default;
	}

	private void SendCharacterCollision(MVControllerColliderHit controllerColliderHit)
	{
	}

	private static float DistanceR3SpaceToESpace(float distance, Vector3 R3Dir, Vector3 R3Radius)
	{
		return 0f;
	}

	private static float DistanceESpaceToR3Space(float eDistance, Vector3 eDir, Vector3 R3Radius)
	{
		return 0f;
	}

	private static float GetMoveBackDistance(Vector3 ePos, Vector3 eDir, float distance, Vector3 ePoint)
	{
		return 0f;
	}

	private static Vector3 GetNormal(Vector3 ePos, Vector3 eDir, float distance, Vector3 ePoint)
	{
		return default;
	}

	private static float GetCollisionAngle(Vector3 ePos, Vector3 eDir, float distance, Vector3 ePoint)
	{
		return 0f;
	}

	private NoCollisionData HandleNoCollision(Vector3 ePos, Vector3 eVel, bool adjustVerticalOnly)
	{
		return default;
	}

	private static Vector3 GetNormalizedVector(Vector3 InpVec)
	{
		return default;
	}

	protected bool OverlapCheckCollision(Vector3 R3Position)
	{
		return false;
	}

	private List<MVOverlapResult> OverlappingObjects(Vector3 R3Position)
	{
		return null;
	}
}
