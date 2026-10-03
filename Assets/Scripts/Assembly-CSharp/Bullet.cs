using System;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private class CollisionBullet
	{
		public enum State
		{
			Moving = 0,
			Hit = 1,
			OutOfRange = 2,
			Expiring = 3
		}

		private readonly float speed;

		private readonly float range;

		private float distanceTraveled;

		private Vector3 currentPos;

		private Vector3 prevPos;

		private Ray ray;

		private readonly HashSet<int> ignoreWoIDs;

		public CollisionBullet(float range, float speed, Vector3 origin, Vector3 direction, HashSet<int> ignoreWoIDs)
		{
		}

		public State Update(out VoxelHit voxelHit)
		{
			voxelHit = default;
			return State.Moving;
		}

		private bool DoCollisionCheck(out VoxelHit voxelHit)
		{
			voxelHit = default;
			return false;
		}

		private static bool DoBulletCollision(Ray ray, out VoxelHit voxelHit, float distance, HashSet<int> ignoreWoIDs)
		{
			voxelHit = default;
			return false;
		}
	}

	public delegate void OnHitDelegate(VoxelHit hit, Ray lineOfFire);

	public OnHitDelegate onHit;

	public OnHitDelegate onHitLocal;

	public Action<Ray> onOutOfRange;

	private PoolEnums initiatedPoolType;

	private MonoBehaviour pooledObjectReference;

	private HashSet<int> ignoreWoIDs;

	private bool isFired;

	private Ray lineOfFire;

	[SerializeField]
	private TrailRenderer trailRenderer;

	[SerializeField]
	private ParticleSystem pSystem;

	[SerializeField]
	private MeshRenderer[] meshRenderers;

	private CollisionBullet collisionBullet;

	private bool hit;

	private bool hasCleaned;

	private float currentAirTime;

	private float maxAirTime;

	private Vector3 startPosition;

	private Vector3 targetPosition;

	private Transform localTransform;

	private CullingSubscriberBase cullingSubscriberBase;

	private VoxelHit voxelHit;

	public PoolEnums InitiatedPoolType
	{
		get
		{
			return PoolEnums.CenterGunBullet;
		}
		set
		{
		}
	}

	public MonoBehaviour PooledObjectReference
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static Bullet CreateBullet(PoolEnums bulletType, Vector3 pos)
	{
		return null;
	}

	public void ResetBullet()
	{
	}

	public void ReturnToPool(PoolEnums bulletType)
	{
	}

	public void Fire(float speed, float range, Ray lineOfFire, HashSet<int> ignoreWoIDs)
	{
	}

	private void DoFire(float speed, float maxRange)
	{
	}

	private void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public Vector3 FindTargetPos(float maxRange)
	{
		return default;
	}
}
