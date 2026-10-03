using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenerateTextureData : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateTexture_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<byte[]> textureDataCallback;

		public GenerateTextureData _003C_003E4__this;

		private GameObject _003CscreenshotCamObject_003E5__2;

		private Camera _003CscreenshotCam_003E5__3;

		private int _003Cheight_003E5__4;

		private RenderTexture _003CscreenshotRenderTexture_003E5__5;

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
		public _003CGenerateTexture_003Ed__5(int _003C_003E1__state)
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

	public static bool IsCreatingScreenShot { get; private set; }

	public void GenerateTextureDataCameraView(Action<byte[]> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateTexture_003Ed__5))]
	private IEnumerator GenerateTexture(Action<byte[]> textureDataCallback)
	{
		return null;
	}

	public static void AddPostProcessing(GameObject screenshotCamObject, MainCameraManager mainCameraManager, LayerFlags layers)
	{
	}
}
