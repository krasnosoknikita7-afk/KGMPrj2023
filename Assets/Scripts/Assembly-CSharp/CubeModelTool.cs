using System;

internal class CubeModelTool : IState
{
	protected bool waitForMouseUp;

	private static EditCubeChange cubeChange;

	private static int cubeCount;

	public static Action<int, EditCubeChange> OnEditCubeChange;

	public CubeModelingEvent StateType { get; protected set; }

	public virtual bool CursorVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected static void SendCubeEvent(int cubeCount, EditCubeChange cubeChange)
	{
	}

	public void SetStateType(CubeModelingEvent stateTypeEvent)
	{
	}

	public virtual void Enter(CubeModelingStateMachine esm)
	{
	}

	public virtual void Execute(CubeModelingStateMachine e)
	{
	}

	public virtual void Exit(CubeModelingStateMachine esm)
	{
	}

	public void Enter(FSMEntity e)
	{
	}

	public void Execute(FSMEntity e)
	{
	}

	public void Exit(FSMEntity e)
	{
	}

	public virtual void HideCursor()
	{
	}
}
