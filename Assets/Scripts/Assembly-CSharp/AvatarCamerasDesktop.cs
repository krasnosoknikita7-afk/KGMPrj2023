using System.Collections.Generic;
using UnityEngine;

public class AvatarCamerasDesktop : MonoBehaviour, IAvatarCameraController
{
	private AvatarCamerasWrapper avatarCamerasWrapper;

	private MVCameraController cameraController;

	[SerializeField]
	private DesktopFirstPersonCamera firstPersonDesktopCamera;

	[SerializeField]
	private ThirdPersonCamera thirdPersonDesktopCamera;

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
