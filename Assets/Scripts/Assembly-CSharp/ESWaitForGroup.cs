using System.Collections.Generic;

internal class ESWaitForGroup : ESStateBase
{
	private enum WaitForGroupsState
	{
		WaitingForLock = 0,
		WaitingForGroup = 1,
		WaitingForTransferWos = 2
	}

	private bool abort;

	private bool responseReceived;

	private List<int> lockList;

	private int lockCount;

	private WaitForGroupsState state;

	private int createGroupId;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private void WOCM_OnTransferWosResponse(object sender, OnTransferWosResponseEventArgs e)
	{
	}

	public void CreateGroup(EditorStateMachine e)
	{
	}

	private void WOCM_InitializedGameQueryData(object sender, InitializedGameQueryDataEventArgs e)
	{
	}

	private void WOCM_OnHierarchyLockedResponse(object sender, OnHierarchyLockedEventArgs e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}
}
