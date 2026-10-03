using System.Collections.Generic;

public class MVCameraController
{
	private class CameraStack
	{
		private readonly List<MVCameraBase> activeCameras;

		private readonly Dictionary<CameraType, MVCameraBase> cameras;

		public MVCameraBase CurCamera => null;

		public CameraStack(List<MVCameraBase> camerasList, MVCameraController cameraController)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void UpdateCamera(MVCameraController cameraController, ProtectedTransform protectedTransform)
		{
		}

		public void SetCamera(CameraType cameraType, MVCameraController cameraController)
		{
		}

		public void SetCamera(MVCameraBase newCamera, MVCameraController cameraController)
		{
		}

		private void EnterCamera(MVCameraBase newCamera, MVCameraController cameraController)
		{
		}

		private void ClearStack(MVCameraController cameraController)
		{
		}

		public T GetCamera<T>() where T : MVCameraBase
		{
			return null;
		}

		public void PushCamera(CameraType cameraType, MVCameraController cameraController)
		{
		}

		public void PushCamera(MVCameraBase cameraBase, MVCameraController cameraController)
		{
		}

		public void RemoveCamera(CameraType cameraType, MVCameraController cameraController)
		{
		}

		public void RemoveCamera(MVCameraBase cameraBase, MVCameraController cameraController)
		{
		}
	}

	private CameraStack cameraStack;

	public MVCameraBase CurCamera => null;

	public T GetCamera<T>() where T : MVCameraBase
	{
		return null;
	}

	public void Initialize(List<MVCameraBase> cameraBases)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	public void Respawn()
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

	public void UpdateCamera(ProtectedTransform protectedTransform)
	{
	}
}
