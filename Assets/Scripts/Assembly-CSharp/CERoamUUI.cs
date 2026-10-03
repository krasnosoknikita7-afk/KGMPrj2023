using UnityEngine;

public class CERoamUUI : ESStateBase
{
	private int downWorldObjectID;

	private bool enterEditNextFrame;

	private Vector3 centerPos;

	private bool didExit;

	public CERoamUUI(Vector3 centerPos)
	{
	}

	public override void Enter(EditorStateMachine esm)
	{
	}

	public override void Execute(EditorStateMachine esm)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private bool HandleSelect(EditorStateMachine esm)
	{
		return false;
	}

	private bool EnterObject(EditorStateMachine esm)
	{
		return false;
	}
}
