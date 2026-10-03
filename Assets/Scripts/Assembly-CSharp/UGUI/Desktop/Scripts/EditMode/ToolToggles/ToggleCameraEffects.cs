using UnityEngine;
using UnityEngine.Events;

namespace UGUI.Desktop.Scripts.EditMode.ToolToggles
{
	public class ToggleCameraEffects : ToggleHandler
	{
		[SerializeField]
		public ToggleStatHandlerBase toggleStatHandlerBase;

		public bool ignoreCamEffectCallback;

		private void Update()
		{
		}

		public override void ExecuteToggleState(bool toggleState, UnityAction<bool> toggleCallback)
		{
		}
	}
}
