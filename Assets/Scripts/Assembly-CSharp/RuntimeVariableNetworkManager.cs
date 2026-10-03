using System.Collections.Generic;

public class RuntimeVariableNetworkManager
{
	private HashSet<int> runtimeDataVariables;

	private List<int> removeList;

	public void AddRuntimeDataVariables(int woID)
	{
	}

	public bool ContainsRuntimeVariables(int woID)
	{
		return false;
	}

	public void RemoveRuntimeDataVariables(int woID)
	{
	}

	public void SendRuntimeData()
	{
	}

	public bool SendRuntimeData(MVWorldObjectClient wo, bool immediateSend)
	{
		return false;
	}
}
