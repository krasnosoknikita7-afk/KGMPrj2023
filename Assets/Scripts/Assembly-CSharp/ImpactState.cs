using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class ImpactState
{
	public class ImpactDamageRuntimeEventType : IComparable
	{
		private readonly float damageThreshold;

		private readonly RuntimeEventType runtimeEventType;

		public float DamageThreshold => 0f;

		public RuntimeEventType RuntimeEventType => RuntimeEventType.Undefined;

		public ImpactDamageRuntimeEventType(float damageThreshold, RuntimeEventType runtimeEventType)
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private class ImpactDestruction
	{
		private List<ImpactDamageRuntimeEventType> impactDamageRuntimeEventTypes;

		private float velChangeToDamageConstant;

		public ImpactDestruction(params RuntimeEventType[] explosionEvents)
		{
		}

		public void HandleImpactDestruction(float velChangeMagnitude, List<MVControllerColliderHit> moveHits)
		{
		}

		private MVControllerColliderHit GetColliderHit(List<MVControllerColliderHit> moveHits)
		{
			return default;
		}

		private bool TryGetExplosionEvent(out RuntimeEventType runtimeEventType, float damage)
		{
			runtimeEventType = default;
			return false;
		}

		private float GetImpactDamage(float velChangeMagnitude)
		{
			return 0f;
		}

		private void GetMoveHitWithHighestImpactVelocity(ref MVControllerColliderHit colliderHit, List<MVControllerColliderHit> moveHits)
		{
		}
	}

	public Vector3 prevVelocityChangeVector;

	private bool collidedPrevFrame;

	private float averageSoftnessPrevFrame;

	private float maxAccBeforeDamageDealt;

	private float impactDamageMultiplier;

	private float impactDamage;

	private const int suspendImpactDamageFrames = 1;

	private int suspendImpactDamageCounter;

	private ImpactDestruction impactDestruction;

	private List<MVControllerColliderHit> moveHits;

	public float ImpactDamage => 0f;

	public ImpactState(params RuntimeEventType[] explosionEvents)
	{
	}

	public void SuspendImpactDamage()
	{
	}

	private float CalcImpactDamage(float velocityChange)
	{
		return 0f;
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}

	public float UpdateImpactState(Vector3 curVelocity, Vector3 prevVelocity, MVInteractableBase interactableLocal)
	{
		return 0f;
	}
}
