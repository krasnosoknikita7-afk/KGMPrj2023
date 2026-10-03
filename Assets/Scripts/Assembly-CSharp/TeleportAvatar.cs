using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.Common;
using UnityEngine;

public class TeleportAvatar : MonoBehaviour
{
	private delegate void ActionDelegate(float time);

	[CompilerGenerated]
	private sealed class _003CDoForSeconds_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionDelegate body;

		public float duration;

		private float _003Ct_003E5__2;

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
		public _003CDoForSeconds_003Ed__6(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TeleportAvatar _003C_003E4__this;

		private MVRigidBody _003CrigidBody_003E5__2;

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
		public _003CStart_003Ed__8(int _003C_003E1__state)
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

	public float teleportTime;

	public Vector3 targetPosition;

	public Vector3 originPosition;

	public MVAvatarLocal avatar;

	private bool shouldCancelTeleportation;

	[IteratorStateMachine(typeof(_003CDoForSeconds_003Ed__6))]
	private IEnumerator DoForSeconds(float duration, ActionDelegate body)
	{
		return null;
	}

	private float BlockStep(float t, float steps)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__8))]
	private IEnumerator Start()
	{
		return null;
	}

	private void CancelTeleportation()
	{
	}

	private void OnAvatarStateChanged(SpawnRoleModeType mode)
	{
	}

	private void EndTeleportation(MVRigidBody rigidBody)
	{
	}
}
