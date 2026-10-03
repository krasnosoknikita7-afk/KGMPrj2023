using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ToggleStateHandler : ToggleStatHandlerBase
{
	[SerializeField]
	private Sprite toggleOn;

	[SerializeField]
	private Sprite toggleOff;

	protected override void UpdateToggleState()
	{
	}
}
