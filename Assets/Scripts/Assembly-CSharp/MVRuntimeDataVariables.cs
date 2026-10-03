using System.Collections.Generic;

public class MVRuntimeDataVariables
{
	private MVWorldObjectClient owner;

	private List<MVRuntimeDataVariable> variables;

	public MVRuntimeDataVariables(MVWorldObjectClient owner)
	{
	}

	public MVRuntimeDataVariable New(string variableId, float sendInterval, bool writeThrough)
	{
		return null;
	}

	public MVRuntimeDataVariable<T> New<T>(string variableId, float sendInterval, bool writeThrough)
	{
		return null;
	}

	public MVRuntimeDataVariableClampedFloat NewClampedFloat(string variableId, float sendInterval, bool writeThrough, float minValue, float maxValue)
	{
		return null;
	}

	public void Receive(Dictionary<object, object> runtimeData)
	{
	}

	public Dictionary<object, object> Send(bool immediateSend)
	{
		return null;
	}

	public void OnWriteThrough(object value)
	{
	}
}
