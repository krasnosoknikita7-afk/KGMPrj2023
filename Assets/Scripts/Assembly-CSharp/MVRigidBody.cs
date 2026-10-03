using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class MVRigidBody : MVComponent
{
	protected class StuckEvaluator
	{
		internal class StuckObject
		{
			private const float timeBeforeStuck = 2f;

			private float stuckTime;

			private MVOverlapResult overlapResult;

			public MVOverlapResult OverlapResult
			{
				set
				{
				}
			}

			public StuckObject(MVOverlapResult overlapResult)
			{
			}

			public bool IsStuckInObject()
			{
				return false;
			}

			private bool HandleFineGrained()
			{
				return false;
			}
		}

		private Dictionary<int, StuckObject> stuckObjects;

		private Func<List<MVOverlapResult>> getOverlappingObjects;

		private float updateInterval;

		private float updateTime;

		public StuckEvaluator(Func<List<MVOverlapResult>> getOverlappingObjects)
		{
		}

		public bool Update()
		{
			return false;
		}

		private Dictionary<int, MVOverlapResult> GetOverlapDictionary()
		{
			return null;
		}
	}

	protected MVGroundState groundState;

	protected float weight;

	protected float density;

	protected bool isPlayerControlled;

	protected List<Vector3> impulseVectors;

	public abstract bool Grounded { get; }

	public abstract Vector3 Velocity { get; }

	public abstract bool IsMovementLocked { get; set; }

	public bool IsPlayerControlled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void AddImpulse(MVPlayer shooter, Vector3 impulse, bool suspendImpactDamage = false)
	{
	}

	public void AddImpulse(Vector3 impulse, bool suspendImpactDamage = false)
	{
	}

	public virtual void Reset()
	{
	}

	protected void Init()
	{
	}

	protected Vector3 GetImpulse(Vector3 velocity, MVInteractableBase interactableLocal)
	{
		return default;
	}

	protected static Vector3 VelocityDamping(Vector3 velocity, float defaultDampning, MVInteractableBase interactableLocal)
	{
		return default;
	}

	protected static Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default;
	}

	protected Vector3 ApplyGravity(Vector3 velocity, Vector3 velocityPrevFrame, MVInteractableBase interactableLocal)
	{
		return default;
	}

	protected abstract void SuspendImpactDamage();
}
