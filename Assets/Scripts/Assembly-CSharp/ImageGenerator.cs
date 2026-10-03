using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class ImageGenerator
{
	[CompilerGenerated]
	private sealed class _003CCreateTextureFromData_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MVWorldObjectClient wo;

		public Action<byte[]> callback;

		private Texture2D _003CpreviewTexture_003E5__2;

		private GameObject _003CpreviewRoot_003E5__3;

		private GameObject _003CitemCopy_003E5__4;

		private ObjectPreviewer _003CobjectPreviewer_003E5__5;

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
		public _003CCreateTextureFromData_003Ed__0(int _003C_003E1__state)
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

	[IteratorStateMachine(typeof(_003CCreateTextureFromData_003Ed__0))]
	public static IEnumerator CreateTextureFromData(MVWorldObjectClient wo, Action<byte[]> callback)
	{
		return null;
	}
}
