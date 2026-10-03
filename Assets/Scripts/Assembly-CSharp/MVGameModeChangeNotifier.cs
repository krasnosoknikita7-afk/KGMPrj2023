using System.Collections.Generic;

public class MVGameModeChangeNotifier : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	private UpdateCondition _currentState;

	private List<IGameStateControllerSubscriber> UpdateList;

	public void AddUpdateObject(IGameStateControllerSubscriber obj)
	{
	}

	public void RemoveObject(IGameStateControllerSubscriber obj)
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	private UpdateCondition GetPresentState()
	{
		return (UpdateCondition)0;
	}
}
