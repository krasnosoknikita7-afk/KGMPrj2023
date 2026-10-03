using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class ToggleStatHandlerBase : MonoBehaviour
{
	private bool waitingForToggleCallback;

	[SerializeField]
	protected Button button;

	[SerializeField]
	protected bool toggleState;

	[SerializeField]
	protected UnityAction<bool> toggleCallback;

	[SerializeField]
	protected ToggleHandler toggleHandler;

	[SerializeField]
	protected bool usingImageComponent;

	[SerializeField]
	protected Image imageComponent;

	public ToggleStateHandlerOnStartSetValue OnStartSetValue;

	protected Image CurrentImage => null;

	public bool ToggleState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected abstract void UpdateToggleState();

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}

	public virtual bool CurrentToggleState()
	{
		return false;
	}

	public void Toggle()
	{
	}

	private void ToggleCallback(bool newState)
	{
	}
}
