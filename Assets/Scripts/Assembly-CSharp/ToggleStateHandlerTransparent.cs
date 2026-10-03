using UnityEngine;

public class ToggleStateHandlerTransparent : ToggleStatHandlerBase
{
	[SerializeField]
	private float toggled;

	[SerializeField]
	private float notToggled;

	protected override void UpdateToggleState()
	{
	}
}
