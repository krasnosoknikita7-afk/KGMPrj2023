using System.Collections.Generic;
using UnityEngine;

public class AvatarCamerasDesktopBuildMode : MonoBehaviour
{
	private AvatarCamerasWrapper avatarCamerasWrapper;

	private MVCameraController cameraController;

	[SerializeField]
	private JetPackCamera jetPackCamera;

	[SerializeField]
	private AvatarEditModeCamera avatarEditModeCamera;

	public void Initialize(MVBuildModeAvatarLocal avatarLocal)
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
