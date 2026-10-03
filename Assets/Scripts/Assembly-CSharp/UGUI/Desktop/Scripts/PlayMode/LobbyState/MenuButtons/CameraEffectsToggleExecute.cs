using UnityEngine;
using UnityEngine.Events;

namespace UGUI.Desktop.Scripts.PlayMode.LobbyState.MenuButtons
{
	public class CameraEffectsToggleExecute : ToggleHandler
	{
		[SerializeField]
		private ToggleStateHandler toggleStateHandler;

		[SerializeField]
		private ToolTip toolTip;

		private bool hasCallbacks;

		private bool ignoreCamEffectCallback;

		private void Awake()
		{
		}

		private void CamEffectsUpdate(bool obj)
		{
		}

		private static bool StartSetValue()
		{
			return false;
		}

		public override void ExecuteToggleState(bool toggleState, UnityAction<bool> toggleCallback)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
