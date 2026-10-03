using System.Collections.Generic;
using UnityEngine;

public class LimbController
{
	private MVWorldObjectClient avatarWO;

	private Transform limbTransform;

	private Quaternion limbsOriginalRotation;

	private Quaternion modelRotationOffset;

	private Quaternion interpolateTowardsYawRotation;

	private Quaternion interpolateTowardsPitchRotation;

	private Quaternion previousLimbRotation;

	private float interpolationSpeed;

	private float elapsedInterpolationTime;

	private float maxYaw;

	private float maxPitch;

	private float rotationDuration;

	private float elapsedInterpolateAnimationTime;

	private bool shouldRotate;

	private string currentAnimation;

	private List<string> blendAnimations;

	private List<string> cancelAnimations;

	private bool isEventControllingLimb;

	public Quaternion InterpolateTowardsYawRotation => default;

	public Quaternion InterpolateTowardsPitchRotation => default;

	public float InterpolationSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsEventControllingLimb
	{
		set
		{
		}
	}

	public string CurrentAnimation
	{
		set
		{
		}
	}

	public void Initialize(AvatarLimbManager limbManager, MVWorldObjectClient avatarWO, MVBody body, BodyData.PartIndex partIndex, Quaternion modelRotationOffset, Quaternion originalRotation, List<string> blendAnimations, List<string> cancelAnimations, float maxYaw, float maxPitch)
	{
	}

	public void TrySetNewRotation(Quaternion yawRotation, Quaternion PitchRotation)
	{
	}

	public void TrySetNewRotation(Quaternion yawRotation, Quaternion PitchRotation, float duration)
	{
	}

	public void SetNewRotation(Quaternion yawRotation, Quaternion PitchRotation)
	{
	}

	public void SetNewRotation(Quaternion yawRotation, Quaternion PitchRotation, float duration)
	{
	}

	public void StopRotating()
	{
	}

	public void UpdateRotation()
	{
	}

	private void UpdateRotationDuration()
	{
	}

	private bool IsCancelRotation(string currentAnimation)
	{
		return false;
	}

	private bool ShouldBlendWithAnimation(string currentAnimation)
	{
		return false;
	}

	private Quaternion CalculateBlendedRotation()
	{
		return default;
	}

	private void UpdateInterpolation(Quaternion interpolateTowardsRotation)
	{
	}

	private void InterpolateTowardsAnimation(string currentAnimation)
	{
	}

	private Quaternion GetYawRotation(Vector3 localDirection)
	{
		return default;
	}

	private Quaternion GetPitchRotation(Vector3 localDirection)
	{
		return default;
	}

	private Quaternion AddAndClampRotations(Quaternion rotation1, Quaternion rotation2)
	{
		return default;
	}

	public void StartBlendingWithAnimation(string animation)
	{
	}

	public void StopBlendingWithAnimation(string animation)
	{
	}

	public void ResetInterpolation()
	{
	}

	private void FinishInterpolation()
	{
	}
}
