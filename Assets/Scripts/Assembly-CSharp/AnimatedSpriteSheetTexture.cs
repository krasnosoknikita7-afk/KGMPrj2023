using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimatedSpriteSheetTexture : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateTiling_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimatedSpriteSheetTexture _003C_003E4__this;

		private float _003Cy_003E5__2;

		private Vector2 _003Coffset_003E5__3;

		private int _003Ci_003E5__4;

		private int _003Cj_003E5__5;

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
		public _003CUpdateTiling_003Ed__20(int _003C_003E1__state)
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

	[SerializeField]
	private int Columns;

	[SerializeField]
	private int Rows;

	[SerializeField]
	private int emptyRows;

	[SerializeField]
	private int emptyColumnsOnLastRow;

	[SerializeField]
	private int spriteWidth;

	[SerializeField]
	private int spriteHeight;

	[SerializeField]
	private int spriteCellWidth;

	[SerializeField]
	private int spriteCellHeight;

	[SerializeField]
	private int spriteUnusedPixelWidth;

	[SerializeField]
	private int spriteUnusedPixelHeight;

	[SerializeField]
	private float FramesPerSecond;

	[SerializeField]
	private bool RunOnce;

	[SerializeField]
	private Renderer textureRenderer;

	private float cellWidthMultiplier;

	private float cellHeightMultiplier;

	private Material materialCopy;

	public float RunTimeInSeconds => 0f;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTiling_003Ed__20))]
	private IEnumerator UpdateTiling()
	{
		return null;
	}
}
