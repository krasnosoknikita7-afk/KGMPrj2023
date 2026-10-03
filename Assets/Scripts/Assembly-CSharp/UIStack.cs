using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIStack : MonoBehaviour, IUIStack, IEventSystemHandler
{
	private class StackElement
	{
		public readonly GameObject gameObject;

		public readonly bool blockingObject;

		public readonly bool hideAll;

		public readonly bool invisibleBlocker;

		public readonly bool hideAllExceptStackbottom;

		public readonly bool suppressInput;

		public readonly UnityAction onPop;

		public readonly UIGroupFlags group;

		public readonly string name;

		public StackElement(GameObject gameObject, UIPushOption pushOption, UnityAction onPop, UIGroupFlags group)
		{
		}
	}

	private Action uiStackChangedPublisher;

	[SerializeField]
	private GameObject root;

	[SerializeField]
	private GameObject blockingObject;

	[SerializeField]
	private DisableInput inputBlocker;

	[SerializeField]
	private Image blockingObjectImage;

	private float origBlockerAlpha;

	private bool stackReady;

	private List<StackElement> stackableUiElements;

	public bool StackReady => false;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void SubscribeToStackChanges(Action onStackChanged)
	{
	}

	public void UnSubscribeToStackChanges(Action onStackChanged)
	{
	}

	public void Push(GameObject gameObject, UIPushOption pushOption = UIPushOption.None, UnityAction onPop = null, UIGroupFlags group = UIGroupFlags.Default)
	{
	}

	public void Pop()
	{
	}

	public void PopGroups(UIGroupFlags popGroups)
	{
	}

	public bool PopToStackElement(GameObject gameObject)
	{
		return false;
	}

	public void SetStackReady()
	{
	}

	public void PopToGroup(UIGroupFlags group)
	{
	}

	public bool IsUIElementBlocked(GameObject uiElement)
	{
		return false;
	}

	public GameObject Peak()
	{
		return null;
	}

	public bool IsStackEmpty()
	{
		return false;
	}

	private void HideAll()
	{
	}

	private void HideAllExceptStackBottom()
	{
	}

	private void UpdateStack()
	{
	}

	private void UpdateBlocking()
	{
	}

	private void RemoveElement(int index)
	{
	}

	private void FindStackParent(Transform uiElement, ref int index)
	{
	}

	private void SetStackVisible()
	{
	}
}
