using System.Collections.Generic;
using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.EventSystems;

public class FirstTimeElementActivator : MonoBehaviour, IFirstTimeElementActivator, IEventSystemHandler
{
	private bool evaluateActivatableElements;

	private bool isReady;

	[SerializeField]
	private UIStack uiStack;

	[SerializeField]
	private FirstTimeEventSkipPopup firstTimeSkipPopup;

	private Dictionary<FirstTimeEvent, IActivatableFirstTimeUiElement> activatableUiElements;

	private List<FirstTimeEvent> elementsToRemove;

	protected void Start()
	{
	}

	protected void OnDestroy()
	{
	}

	private void OnJoinStateChanged(MVJoinState mvJoinState)
	{
	}

	private void FirstTimeStateReceiver(FirstTimeState firstTimeState, FirstTimeEvent firstTimeEvent)
	{
	}

	private void OnStackChange()
	{
	}

	private void OnXPRewarded()
	{
	}

	private void LateUpdate()
	{
	}

	private void EvaluateActivatableElements()
	{
	}

	public void RegisterActivatableElement(IActivatableFirstTimeUiElement firstTimeEventHandlerListener)
	{
	}

	public void SkipFirstTimeEvent(FirstTimeEvent firstTimeEvent, FirstTimeActivatableElementBase firstTimeActivatable)
	{
	}

	public void UnRegisterActivatableElement(IActivatableFirstTimeUiElement firstTimeEventHandlerListener)
	{
	}

	public void RequestEvaluateActivatableElements()
	{
	}
}
