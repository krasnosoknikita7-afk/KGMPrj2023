using UnityEngine;
using UnityEngine.Events;

public class ToggleLogic : ToggleHandler
{
	[SerializeField]
	private ToggleStatHandlerBase toggleStatHandlerBase;

	private void Update()
	{
	}

	public override void ExecuteToggleState(bool toggleState, UnityAction<bool> toggleCallback)
	{
	}
}
