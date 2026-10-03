using UnityEngine;

public class AvatarLimbManagerRemote : AvatarLimbManager
{
	private class AvatarHeadRotationHandlerRemote : AvatarHeadRotationHandler
	{
		private Quaternion remoteYawRotation;

		private Quaternion remotePitchRotation;

		public override void Initialize(AvatarLimbManager limbManager, LimbRotator limbRotator, AvatarLookDirectionHandler lookDirectionHandler)
		{
		}

		public override void UpdateRotation()
		{
		}

		public void SetRotationRemotely(float yaw, float pitch)
		{
		}
	}

	private class AvatarLimbDataManagerRemote
	{
		private float newHeadYawValue;

		private float newHeadPitchValue;

		private float newPointYawValue;

		private float newPointPitchValue;

		private AvatarLimbManagerRemote limbManager;

		public void Initialize(LimbRotationRuntimeData limbRotationRuntimeData, AvatarLimbManagerRemote limbManager)
		{
		}

		private void OnHeadYawChange(object headYaw)
		{
		}

		private void OnHeadPitchChange(object headPitch)
		{
		}

		private void UpdateHeadRotation()
		{
		}

		private void OnPointYawChange(object pointYaw)
		{
		}

		private void OnPointPitchChange(object pointPitch)
		{
		}

		private void UpdatePointRotation()
		{
		}

		private void OnEmoteDataChange(object newEmoteData)
		{
		}
	}

	private class AvatarPointingHandlerRemote : AvatarPointingHandler
	{
		private Quaternion remoteYawRotation;

		private Quaternion remotePitchRotation;

		public override void Initialize(AvatarLimbManager limbManager, LimbRotator limbRotator, AvatarEnabledChangeHandler enableChangeHandler)
		{
		}

		public override void UpdatePointing(Vector3 localLookDirection)
		{
		}

		public void SetRotationRemotely(float yaw, float pitch)
		{
		}
	}

	private AvatarHeadRotationHandlerRemote headRotationHandler;

	private AvatarPointingHandlerRemote pointingHandler;

	private AvatarLimbDataManagerRemote dataManager;

	public override void Initialize(MVWorldObjectClient avatarWO, MVBody body, AvatarEnabledChangeHandler enabledChangeHandler, LimbRotationRuntimeData limbRotationRuntimeData)
	{
	}

	public override void UpdateLimbRotations(Vector3 lookDirection)
	{
	}

	public void UpdateHeadRotationRemotely(float yaw, float pitch)
	{
	}

	public void UpdatePointingRemotely(float yaw, float pitch)
	{
	}

	public override void StartEmote(EmoteTypes emoteType)
	{
	}

	private void OnHeadRotationDataChange(object newHeadRotationData)
	{
	}

	private void OnPointRotationDataChange(object newPointRotationData)
	{
	}
}
