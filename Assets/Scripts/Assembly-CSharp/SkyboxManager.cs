using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
	public delegate void SkyboxColorChangedDelegate(Color newColor);

	[CompilerGenerated]
	private sealed class _003CDoAnimate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkyboxManager _003C_003E4__this;

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
		public _003CDoAnimate_003Ed__23(int _003C_003E1__state)
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
	[Header("Configuration")]
	private float skyContrast;

	[SerializeField]
	private AnimationCurve lightDuskDawnFalloff;

	[SerializeField]
	[Header("Dependencies")]
	private Light sunLight;

	[SerializeField]
	private Camera targetCamera;

	[SerializeField]
	private MeshRenderer horizontalPlane;

	public static readonly Color defaultColor;

	public static readonly Color brightAmbient;

	public const float defaultSunAngle = 80f;

	public const float defaultFogDensity = 0.007f;

	public Color currentColor;

	public float currentSunAngle;

	public float currentFogDensity;

	public SkyboxColorChangedDelegate OnSkyboxColorChanged;

	private List<MVSkybox> mvSkyboxes;

	private Color targetColor;

	private float targetSunAngle;

	private float targetFogDensity;

	private bool initialized;

	private bool pendingLateInitialization;

	public void RefreshColor()
	{
	}

	public void Add(MVSkybox skybox)
	{
	}

	public void Remove(MVSkybox skybox)
	{
	}

	[IteratorStateMachine(typeof(_003CDoAnimate_003Ed__23))]
	private IEnumerator DoAnimate()
	{
		return null;
	}

	protected void Awake()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	protected void OnEnable()
	{
	}

	private void Initialize()
	{
	}

	private void CalcAndSetSkyboxSettings()
	{
	}

	private void ComputeSkyboxSettings(out Color color, out float sunAngle, out float fogDensity)
	{
		color = default;
		sunAngle = default;
		fogDensity = default;
	}

	private void SetColor(Color color, float sunAngle, float fogDensity)
	{
	}

	public static void ResetAmbientLight()
	{
	}
}
