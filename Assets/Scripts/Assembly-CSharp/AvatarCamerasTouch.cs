using System.Collections.Generic;
using UnityEngine;

public class AvatarCamerasTouch : MonoBehaviour, IAvatarCameraController
{
	private AvatarCamerasWrapper avatarCamerasWrapper;

	private MVCameraController cameraController;

	[SerializeField]
	private AndroidFirstPersonCamera firstPersonMobileCamera;

	[SerializeField]
	private AndroidThirdPersonCamera thirdPersonMobileCamera;

	[SerializeField]
	private LobbyStateCamera lobbyStateCamera;

	[SerializeField]
	private TimeAttackFlagDebriefingCamera timeAttackFlagDebriefingCamera;

	[SerializeField]
	private TimeAttackFlagCountdownCamera timeAttackFlagCountdownCamera;

	[SerializeField]
	private GhostCamera ghostCamera;

	[SerializeField]
	private DeadCamera deadCamera;

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public void ActivateCameraController()
	{
	}

	public void SetCamera(CameraType cameraType)
	{
	}

	public void SetCamera(MVCameraBase cameraBase)
	{
	}

	public void PushCamera(CameraType cameraType)
	{
	}

	public void PushCamera(MVCameraBase cameraBase)
	{
	}

	public void RemoveCamera(CameraType cameraType)
	{
	}

	public void RemoveCamera(MVCameraBase cameraBase)
	{
	}

	public List<MVCameraBase> GetCameraBases()
	{
		return null;
	}
}
