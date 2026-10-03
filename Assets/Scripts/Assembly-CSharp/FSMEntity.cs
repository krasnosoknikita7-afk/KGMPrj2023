using System.Collections.Generic;

public class FSMEntity
{
	protected StateTransitionTable transitionTable;

	protected IState currentState;

	public object prevEvent;

	public object curEvent;

	public object nextEvent;

	protected string stateName;

	protected Dictionary<object, object> data;

	private bool clearStack;

	private Stack<EditorEvent> stateStack;

	protected bool lockState;

	public Dictionary<object, object> Data => null;

	public bool LockState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public object Event
	{
		set
		{
		}
	}

	public virtual void Update()
	{
	}

	public void PushState(EditorEvent nextState)
	{
	}

	public void PushState(EditorEvent nextState, EditorEvent overridePushState)
	{
	}

	public bool PopState()
	{
		return false;
	}

	public void ClearStateStack()
	{
	}
}
