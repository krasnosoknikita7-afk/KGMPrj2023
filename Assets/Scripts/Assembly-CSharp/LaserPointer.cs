using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaserPointer : MonoBehaviour, ILaserPointer
{
	private enum NetworkStateKey : byte
	{
		State = 10,
		TargetX = 11,
		TargetY = 12,
		TargetZ = 13,
		IsFiring = 14,
		CubeMaterial = 15
	}

	[CompilerGenerated]
	private sealed class _003CDoDeactivateLaserAfterDuration_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LaserPointer _003C_003E4__this;

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
		public _003CDoDeactivateLaserAfterDuration_003Ed__46(int _003C_003E1__state)
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

	public Vector3 offset;

	public Transform cube;

	public LineRenderer lineRenderer;

	public Material insertingMaterial;

	public Material deleteMaterial;

	public Material transformingMaterial;

	public Color beamObjectColor;

	public Color beamDeleteColor;

	public Color beamEditColor;

	private float lastSyncTime;

	private Dictionary<object, object> syncBuffer;

	private Material currentCubeMaterial;

	private byte currentCubeMaterialId;

	private Color beamColor;

	private LaserPointerState state;

	private Vector3 relativeTargetPosition;

	private Vector3 relativeCurrentTargetPosition;

	private bool isFiring;

	private float activeDuration;

	private float currentLaserAlpha;

	private const float syncInverval = 0.4f;

	[SerializeField]
	private Renderer cubeRenderer;

	[SerializeField]
	private MeshFilter cubeMeshFilter;

	private bool isActive;

	private bool isLocal;

	private MVRuntimeDataVariable currentItem;

	public Renderer CubeRenderer => null;

	public MeshFilter CubeMeshFilter => null;

	public void SetLaserActiveState(bool isActive)
	{
	}

	public void Initialize(bool isLocal, MVRuntimeDataVariable currentItem, Transform parent)
	{
	}

	private void OnChange(object newvalue)
	{
	}

	public void SetCurrentCubeMaterial(byte cubeMaterial)
	{
	}

	public void SetLaserCubeVisible(bool visible)
	{
	}

	public void ChangeState(LaserPointerState newState)
	{
	}

	public void UpdatePosition(Vector3 to)
	{
	}

	public void ActivateLaserForDuration(float duration)
	{
	}

	public void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	public void OnEquip()
	{
	}

	public void SubscribeToCommands()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CDoDeactivateLaserAfterDuration_003Ed__46))]
	private IEnumerator DoDeactivateLaserAfterDuration()
	{
		return null;
	}

	private void ApplyMaterialForState()
	{
	}

	protected void SyncState(Dictionary<object, object> newState)
	{
	}

	protected void IntervalSyncState(Dictionary<object, object> newState, float interval)
	{
	}
}
