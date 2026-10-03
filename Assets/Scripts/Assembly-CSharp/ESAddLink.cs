using MV.WorldObject;
using UnityEngine;

internal class ESAddLink : ESStateBase
{
	private Link tempLink;

	private WorldObjectClientRef woRef;

	private Color originalRedConnectorColor;

	private Color originalBlueConnectorColor;

	public float FadeDuration;

	private Color startColor;

	private Color endColor;

	private float lastColorChangeTime;

	private Material materialToPulse;

	public override void Enter(EditorStateMachine esm)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private void LeaveAddLink(EditorStateMachine e)
	{
	}

	private bool DoAddLink()
	{
		return false;
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private void PulseColor()
	{
	}
}
