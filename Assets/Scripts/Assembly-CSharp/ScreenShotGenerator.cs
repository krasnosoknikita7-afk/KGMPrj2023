using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScreenShotGenerator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obj;

		public ScreenShotGenerator _003C_003E4__this;

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
		public _003CGenerateCoroutine_003Ed__19(int _003C_003E1__state)
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

	public Texture2D genTexture;

	private RenderTexture genRenderTexture;

	private Camera shotCamera;

	private Action<byte[]> generatedScreenShotPNGCallback;

	private Action<Texture2D> generatedScreenShotTexCallback;

	private Vector3 cameraOffset;

	private Vector3 lookAtOffset;

	private bool clonedObject;

	private bool generating;

	private GameObject targetObject;

	private Bounds targetBounds;

	private const int width = 512;

	private const int height = 512;

	private static readonly int renderLayers;

	private static ScreenShotGenerator CreateInstance()
	{
		return null;
	}

	public static void Generate(GameObject obj, Vector3 cameraOffset, Vector3 lookAtOffset, Action<byte[]> generatedScreenShotPNGCallback, bool cloneObject = false)
	{
	}

	public static void Generate(GameObject obj, Vector3 cameraOffset, Vector3 lookAtOffset, Action<Texture2D> generatedScreenShotTexCallback, bool cloneObject = false)
	{
	}

	private void StartGenerate(GameObject obj, Vector3 cameraOffset, Vector3 lookAtOffset, Action<byte[]> generatedScreenShotPNGCallback, bool clonedObject)
	{
	}

	private void StartGenerate(GameObject obj, Vector3 cameraOffset, Vector3 lookAtOffset, Action<Texture2D> generatedScreenShotTexCallback, bool clonedObject)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateCoroutine_003Ed__19))]
	private IEnumerator GenerateCoroutine(GameObject obj)
	{
		return null;
	}

	private void GenerateTexture()
	{
	}

	private void InitCamera(int width, int height)
	{
	}

	private Vector3 Translate(Vector3 pos, Transform relativeTo, Vector3 translation)
	{
		return default;
	}

	private void OnPreRender()
	{
	}
}
