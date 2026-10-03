using System;
using System.Collections.Generic;
using UnityEngine;

public class GhostEye : MonoBehaviour
{
	private enum GhostEyeState
	{
		RandomEyeRoll = 0,
		LookAtTarget = 1,
		DieRollback = 2,
		SneakySideToSide = 3
	}

	private interface IGhostEyeState
	{
		void Enter(GhostEye ghostEye);

		Quaternion Update(GhostEye ghostEye);

		void Exit();
	}

	private abstract class IdleBase : IGhostEyeState
	{
		protected float rotatationPrSecond;

		protected float wrappedTime;

		protected const float pi2 = (float)Math.PI * 2f;

		protected float direction;

		protected float radiusPitch;

		protected float radiusYaw;

		public virtual void Enter(GhostEye ghostEye)
		{
		}

		public virtual Quaternion Update(GhostEye ghostEye)
		{
			return default;
		}

		public virtual void Exit()
		{
		}

		protected void UpdateWrappedTime(float deltaTime)
		{
		}

		protected Quaternion GetYawRotation()
		{
			return default;
		}

		private float GetYaw()
		{
			return 0f;
		}
	}

	private class DieRollback : IGhostEyeState
	{
		private const float rollbackPitch = -90f;

		private const float rollbackTime = 1f;

		private float currentRollbackTime;

		private Quaternion rollbackRotation;

		public void Enter(GhostEye ghostEye)
		{
		}

		public Quaternion Update(GhostEye ghostEye)
		{
			return default;
		}

		public void Exit()
		{
		}
	}

	private class RandomEyeRoll : IdleBase
	{
		public override Quaternion Update(GhostEye ghostEye)
		{
			return default;
		}

		private Quaternion GetEyeRollRotation()
		{
			return default;
		}

		private Quaternion GetPitchRotation()
		{
			return default;
		}

		private float GetPitch()
		{
			return 0f;
		}

		public override void Exit()
		{
		}
	}

	private class LookAtTarget : IGhostEyeState
	{
		private Vector3 target;

		private float maxPitch;

		private float maxYaw;

		public void Enter(GhostEye ghostEye)
		{
		}

		public Quaternion Update(GhostEye ghostEye)
		{
			return default;
		}

		private Quaternion GetClampedYawRotation(Vector3 localTargetDirection)
		{
			return default;
		}

		private Quaternion GetClampedPitchRotation(Vector3 localTargetDirection)
		{
			return default;
		}

		private bool TryGetLocalTargetDir(GhostEye ghostEye, out Vector3 localTargetDir)
		{
			localTargetDir = default;
			return false;
		}

		private float GetPitch(Vector3 localTargetPosition)
		{
			return 0f;
		}

		private float GetSignedYaw(Vector3 localTargetPosition)
		{
			return 0f;
		}

		public void Exit()
		{
		}

		public void SetTarget(Vector3 target)
		{
		}
	}

	private class SneakySideToSide : IdleBase
	{
		public override Quaternion Update(GhostEye ghostEye)
		{
			return default;
		}

		private Quaternion GetSneakySideToSideRotation()
		{
			return default;
		}
	}

	private GhostEyeState currentEyeState;

	private readonly Dictionary<GhostEyeState, IGhostEyeState> ghostEyeStates;

	private const float transitionTime = 10f;

	private float currentTransitionTime;

	public float maxPitch;

	public float maxYaw;

	public Transform eyeBall;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Spawn()
	{
	}

	private void SetEyeState(GhostEyeState ghostEyeState)
	{
	}

	public void UpdateLookAtTarget(Vector3 target)
	{
	}

	public void ClearLookAtTarget()
	{
	}

	private Quaternion TransitionSmooth(Quaternion newRotation)
	{
		return default;
	}
}
