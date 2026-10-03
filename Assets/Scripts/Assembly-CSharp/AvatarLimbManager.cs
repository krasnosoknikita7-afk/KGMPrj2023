using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class AvatarLimbManager
{
	protected class AvatarEmote
	{
		public Action<EmoteTypes> OnEmoteEnd;

		protected EmoteTypes emote;

		protected LimbRotator limbRotator;

		protected bool isActive;

		protected float duration;

		protected float lifeTime;

		public float LifeTime => 0f;

		public virtual void Initialize(LimbRotator limbRotator, float lifeTime)
		{
		}

		public virtual void StartEmote()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void StopEmote()
		{
		}
	}

	protected class EmoteData
	{
		public AvatarEmote emote;

		public short priority;
	}

	protected class AvatarEmoteHandler
	{
		protected AvatarLimbManager limbManager;

		protected Dictionary<EmoteTypes, EmoteData> emoteDatas;

		protected EmoteData currentRunningEmoteData;

		protected bool isActive;

		public Action<string> OnEmoteStart;

		public Action<int> OnEmoteUpdate;

		public void Initialize(AvatarLimbManager limbManager, AvatarLookDirectionHandler lookDirectionHandler, AvatarPointingHandler pointingHandler, AvatarHeadRotationHandler headRotationHandler, LimbRotator limbRotator, AvatarEnabledChangeHandler enableChangeHandler)
		{
		}

		protected virtual void CreateLimbEvents(AvatarLimbManager limbManager, AvatarLookDirectionHandler lookDirectionHandler, AvatarPointingHandler pointingHandler, AvatarHeadRotationHandler headRotationHandler, LimbRotator limbRotator)
		{
		}

		private EmoteData CreateEmoteData(AvatarEmote emote, LimbRotator limbRotator, float lifeTime, short priority)
		{
			return null;
		}

		public virtual void UpdateEmotes()
		{
		}

		protected bool CanStartEmote(EmoteData emoteData)
		{
			return false;
		}

		public void TryStartEmote(EmoteTypes emoteType)
		{
		}

		protected void StartEmote(EmoteTypes emoteType)
		{
		}

		private void OnEmoteEnd(EmoteTypes emoteType)
		{
		}

		public void StopAllEmotes()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}

	protected class AvatarHeadRotationHandler
	{
		protected float idleTime;

		protected LimbRotator limbRotator;

		protected const float maxYaw = 90f;

		protected const float maxPitch = 45f;

		protected bool shouldLean;

		public virtual void Initialize(AvatarLimbManager limbManager, LimbRotator limbRotator, AvatarLookDirectionHandler lookDirectionHandler)
		{
		}

		public virtual void UpdateRotation()
		{
		}

		protected virtual void UpdateIdleTimer()
		{
		}

		protected void RotateTorso(Quaternion yawRotation, Quaternion pitchRotation)
		{
		}

		protected void RotateHead(Quaternion yawRotation, Quaternion pitchRotation)
		{
		}

		protected float CalculateTorsoRotationModifier(float yawAngle)
		{
			return 0f;
		}

		protected float CalculateHeadPitchRotationModifier(float yawAngle)
		{
			return 0f;
		}

		protected Quaternion ClampQuaternion(Quaternion rotation)
		{
			return default;
		}

		protected void ResetIdleTimer()
		{
		}

		public void ResetIdleTimer(EmoteTypes emoteType)
		{
		}
	}

	protected class AvatarLookDirectionHandler
	{
		public Action<float> OnLookDirectionYawChange;

		public Action<float> OnLookDirectionPitchChange;

		public Action OnRotationChange;

		private MVWorldObjectClient avatarWO;

		private Vector3 localLookDirection;

		private float previousYaw;

		private float previousPitch;

		private Vector3 previousLookDirection;

		public Vector3 LocalLookDirection => default;

		public void Initialize(MVWorldObjectClient avatarWO)
		{
		}

		public void Update(Vector3 lookDirection)
		{
		}

		private void UpdateYaw()
		{
		}

		private void UpdatePitch()
		{
		}

		private void CheckForRotation()
		{
		}
	}

	protected class AvatarNodEmote : AvatarEmote
	{
		private LimbController headController;

		private float originalInterpolationSpeed;

		private const float nodAngle = 15f;

		private const float amountOfRotations = 5f;

		public override void Initialize(LimbRotator limbRotator, float lifeTime)
		{
		}

		public override void StartEmote()
		{
		}

		public override void StopEmote()
		{
		}

		public override void Update()
		{
		}

		private void HandleRotation()
		{
		}

		private void RotateHead(Quaternion pitchRotation)
		{
		}
	}

	protected class AvatarPointingHandler
	{
		protected Vector3 prevLookDirection;

		protected AvatarLimbManager limbManager;

		protected LimbRotator limbRotator;

		protected float pointingDuration;

		protected float elapsedPointingTime;

		protected Vector3 pointingDirection;

		protected bool shouldPoint;

		protected bool isActive;

		public virtual void Initialize(AvatarLimbManager limbManager, LimbRotator limbRotator, AvatarEnabledChangeHandler enableChangeHandler)
		{
		}

		public virtual void UpdatePointing(Vector3 localLookDirection)
		{
		}

		protected void HandlePointing(Quaternion yawRotation, Quaternion pitchRotation)
		{
		}

		protected void StopPointing()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}
	}

	protected class AvatarShakeEmote : AvatarEmote
	{
		private LimbController headController;

		private float originalInterpolationSpeed;

		private const float shakeAngle = 25f;

		private const float amountOfRotations = 5f;

		public override void Initialize(LimbRotator limbRotator, float lifeTime)
		{
		}

		public override void StartEmote()
		{
		}

		public override void StopEmote()
		{
		}

		public override void Update()
		{
		}

		private void HandleRotation()
		{
		}

		private void RotateHead(Quaternion yawRotation)
		{
		}
	}

	protected class AvatarWaveEmote : AvatarEmote
	{
		private LimbController RArmController;

		private LimbController LArmController;

		private float originalInterpolationSpeed;

		private const float waveAngle = 25f;

		private const float amountOfRotations = 8f;

		public override void Initialize(LimbRotator limbRotator, float lifeTime)
		{
		}

		public override void StartEmote()
		{
		}

		public override void StopEmote()
		{
		}

		public override void Update()
		{
		}

		private void HandleArmRotation(LimbController armController, float yawAngle)
		{
		}

		private void MoveArmUpwards(LimbController armController, Quaternion yawRotation)
		{
		}

		private void MoveArmDownwards(LimbController armController, Quaternion yawRotation)
		{
		}
	}

	protected class LimbRotator
	{
		private Dictionary<BodyData.PartIndex, LimbController> limbControllers;

		private bool isActive;

		public LimbController GetLimbController(BodyData.PartIndex partIndex)
		{
			return null;
		}

		private bool HasLimbController(BodyData.PartIndex partIndex)
		{
			return false;
		}

		public void Initialize(MVWorldObjectClient avatarWO, MVBody body, AvatarLimbManager limbManager)
		{
		}

		private void OnAnimationChange(string newAnimation)
		{
		}

		private void CreateLimbController(BodyData.PartIndex partIndex, MVWorldObjectClient avatarWO, MVBody body, AvatarLimbManager limbManager)
		{
		}

		public void UpdateLimbs()
		{
		}

		public void TrySetLimbRotation(BodyData.PartIndex partIndex, Quaternion limbYawRotation, Quaternion limbPitchRotation)
		{
		}

		public void SetLimbRotation(BodyData.PartIndex partIndex, Quaternion limbYawRotation, Quaternion limbPitchRotation, float duration)
		{
		}

		public void StopLimbRotation(BodyData.PartIndex partIndex)
		{
		}

		public void StartBlendingWithAnimation(BodyData.PartIndex partIndex, string animation)
		{
		}

		public void StopBlendingWithAnimation(BodyData.PartIndex partIndex, string animation)
		{
		}

		public void SetIsActive(bool shouldBeActive)
		{
		}
	}

	public Action OnAvatarRotate;

	public Action<string> OnEmoteStart;

	protected MVWorldObjectClient avatarWO;

	protected AvatarEmoteHandler emoteHandler;

	protected LimbRotator limbRotator;

	protected AvatarLookDirectionHandler lookDirectionHandler;

	private Quaternion previousTransformRotation;

	private const float maxYawAllowed = 30f;

	public virtual void Initialize(MVWorldObjectClient avatarWO, MVBody body, AvatarEnabledChangeHandler enabledChangeHandler, LimbRotationRuntimeData limbRotationRuntimeData)
	{
	}

	public virtual void UpdateLimbRotations(Vector3 lookDirection)
	{
	}

	protected void CheckAvatarRotation()
	{
	}

	protected void OnStartEmote(string newAnimation)
	{
	}

	private float QuaternionAngleToNormalAngle(float angle)
	{
		return 0f;
	}

	public void SetLimbRotatorActivity(bool shouldBeActive)
	{
	}

	public abstract void StartEmote(EmoteTypes emoteType);
}
