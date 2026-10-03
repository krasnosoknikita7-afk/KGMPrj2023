using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AvatarScreenshotGenerator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateScreenshot_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarScreenshotGenerator _003C_003E4__this;

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
		public _003CGenerateScreenshot_003Ed__9(int _003C_003E1__state)
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

	public Vector3 cameraOffset;

	public Vector3 lookAtOffset;

	public string animationToShoot;

	public float animationTime;

	private ParticleSystem[] particleSystems;

	private BoneAnimation boneAnimation;

	private GameObject bodyCloneGO;

	private Action<Texture2D> screenShotDataTexHandler;

	public static void Generate(GameObject bodyCloneGO, Action<Texture2D> screenShotDataTexHandler)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateScreenshot_003Ed__9))]
	public IEnumerator GenerateScreenshot()
	{
		return null;
	}

	private void ScreenShotDataTexHandler(Texture2D screenshotTex)
	{
	}
}
