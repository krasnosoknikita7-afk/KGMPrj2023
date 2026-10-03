using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ReviveScreenshotGenerator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateTexture_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int width;

		public int height;

		public Vector3 cameraPos;

		public Quaternion cameraRot;

		public Action<byte[]> textureDataCallback;

		public ReviveScreenshotGenerator _003C_003E4__this;

		private GameObject _003CscreenshotCamObject_003E5__2;

		private Camera _003CscreenshotCam_003E5__3;

		private RenderTexture _003CscreenshotRenderTexture_003E5__4;

		private Camera _003CcullingCam_003E5__5;

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
		public _003CGenerateTexture_003Ed__1(int _003C_003E1__state)
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

	public void GenerateTextureDataCameraViewAtTransform(Action<byte[]> callback, Vector3 cameraPos, Quaternion cameraRot, int width, int height)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateTexture_003Ed__1))]
	private IEnumerator GenerateTexture(Action<byte[]> textureDataCallback, Vector3 cameraPos, Quaternion cameraRot, int width, int height)
	{
		return null;
	}
}
