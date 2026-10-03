using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AllWorldObjectTriggerBoxEvents : MonoBehaviour
{
	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerEnter;

	[CompilerGenerated]
	private EventHandler<TriggerEventArgs> m_TriggerExit;

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

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
