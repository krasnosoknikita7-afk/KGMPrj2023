using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class FirstTimeButtonClicked : FirstTimeEventHandler
{
	private bool isReady;

	private bool buttonHasBeenClicked;

	[SerializeField]
	private Button button;

	[SerializeField]
	private FirstTimeActivatableElementBase firstTimeActivatableElementBase;

	private void Start()
	{
	}

	private void FirstTimeStateReceiver(FirstTimeState firstTimeState, FirstTimeEvent latestFirstTimeEvent)
	{
	}

	private void Clicked()
	{
	}

	private void HandleFirstTimeEvent()
	{
	}

	private void OnDestroy()
	{
	}
}
