using UnityEngine;
using UnityEngine.Events;

public class FullscreenToggleExecute : ToggleHandler
{
	[SerializeField]
	private ToggleStateHandler toggleStateHandler;

	private void Awake()
	{
	}

	private bool StartSetValue()
	{
		return false;
	}

	public override void ExecuteToggleState(bool toggleState, UnityAction<bool> toggleCallback)
	{
	}

	private void FullscreenChanged(bool fullscreenState)
	{
	}
}
