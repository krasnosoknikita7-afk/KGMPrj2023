using System.Collections.Generic;

public abstract class StateTransitionTable
{
	protected Dictionary<object, IState> table;

	public void SetState(object evt, IState state)
	{
	}

	public IState GetState(object evt)
	{
		return null;
	}
}
