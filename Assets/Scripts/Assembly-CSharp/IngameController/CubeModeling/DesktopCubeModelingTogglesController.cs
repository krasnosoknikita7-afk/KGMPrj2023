using UGUI.Desktop.Scripts.EditMode.ToolToggles;
using UnityEngine;

namespace IngameController.CubeModeling
{
	public class DesktopCubeModelingTogglesController : MonoBehaviour
	{
		[SerializeField]
		private ToggleDrawPlaneHandlerTerrain toggleDrawPlane;

		[SerializeField]
		private ToggleSnapToGrid toggleSnapToGrid;

		[SerializeField]
		private ToggleLogic toggleLogic;

		[SerializeField]
		private EnterPlayModeButton togglePlayMode;

		[SerializeField]
		private ToggleCameraEffects toggleCameraEffects;

		private void Awake()
		{
		}

		public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
		{
		}

		private void OnGameCameraEffectsChange(bool obj)
		{
		}

		private bool StartSetValue()
		{
			return false;
		}

		private void CamEffectsUpdate(bool obj)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
