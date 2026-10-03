using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioOnOffComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFader_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioOnOffComponent _003C_003E4__this;

		public float minEndPoint;

		public float maxEndPoint;

		private float _003Ccounter_003E5__2;

		private float _003CstartFade_003E5__3;

		private float _003CfadeToNum_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFader_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject audioSourcePrefab;

	public bool loop;

	public StartLoop startLoop;

	public AudioClip onClip;

	public float onMinPitch;

	public float onMaxPitch;

	public float onMinVol;

	public float onMaxVol;

	public float fadeSpeed;

	private float fadeNum;

	protected AudioSource onOffAudioSource;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFader_003Ed__13))]
	private IEnumerator Fader(float minEndPoint, float maxEndPoint)
	{
		return null;
	}

	public virtual void TurnOn()
	{
	}

	public virtual void TurnOff()
	{
	}

	protected void PlayClip(AudioSource aS, AudioClip aC, bool loop, float minPitch, float maxPitch, float minVol, float maxVol)
	{
	}
}
