using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerBoxEvents : MonoBehaviour
{
	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerEnterOverride;

	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerExitOverride;

	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerEnter;

	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerExit;

	[SerializeField]
	[Tooltip("Will be fetched with GetComponent<Collider>(), if null.")]
	private Collider triggerCollider;

	private bool isInTrigger;

	public Collider Collider => null;

	public bool IsInTrigger => false;

	public event EventHandler<TriggerEventArgs> TriggerEnterOverride
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<TriggerEventArgs> TriggerExitOverride
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<TriggerEventArgs> TriggerEnter
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<TriggerEventArgs> TriggerExit
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected void OnValidate()
	{
	}

	public void OnMVTriggerEnter(Collider other)
	{
	}

	public void OnMVTriggerExit(Collider other)
	{
	}

	private MVWorldObjectClient GetValidWorldObject(Collider other)
	{
		return null;
	}
}
