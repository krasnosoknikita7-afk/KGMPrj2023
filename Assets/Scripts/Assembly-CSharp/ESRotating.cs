using System.Collections.Generic;
using UnityEngine;

internal class ESRotating : ESStateBase
{
	public const string RotationDegreesStepKey = "rotationDegreesStep";

	public const string RotationModeKey = "rotationMode";

	private float rotationSpeed;

	private RotationMode rotationMode;

	private float prevMouseX;

	private float prevMouseY;

	private float rotateThreshold;

	private float xAcc;

	private float yAcc;

	private float mouseSensitivity;

	private List<WorldObjectClientRef> targets;

	private Vector3 pivot;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}
}
