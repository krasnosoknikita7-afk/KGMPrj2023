using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RailRay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoShowRay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RailRay _003C_003E4__this;

		public Vector3 hit;

		private Color _003CendColor_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CDoShowRay_003Ed__20(int _003C_003E1__state)
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

	public Vector3 target;

	public float radius;

	public Color startColor;

	public AnimationCurve implosionFade;

	[SerializeField]
	private LineRenderer rayRenderer;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private PoolEnums railEnumType;

	private Vector3 origin;

	private Vector3 hit;

	private Color endColor;

	private float time;

	private float elapsed;

	public LineRenderer RayRenderer => null;

	public ParticleSystem Particles
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CDoShowRay_003Ed__20))]
	private IEnumerator DoShowRay(Vector3 hit)
	{
		return null;
	}
}
