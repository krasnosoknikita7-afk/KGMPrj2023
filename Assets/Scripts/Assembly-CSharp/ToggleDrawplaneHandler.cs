using UnityEngine;
using UnityEngine.Events;

public class ToggleDrawplaneHandler : ToggleHandler
{
	[SerializeField]
	private ToggleStatHandlerBase toggleStatHandlerBase;

	[SerializeField]
	private GameObject drawPlaneControls;

	private void OnEnable()
	{
	}

	public override void ExecuteToggleState(bool toggleState, UnityAction<bool> toggleCallback)
	{
	}
}
