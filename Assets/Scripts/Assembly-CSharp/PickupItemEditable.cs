using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class PickupItemEditable : PickupItemWithDelay
{
	protected abstract class EditableItemConfiguration
	{
		public string name;

		public int cubeModelId;

		public int maxAmmo;

		public float damage;

		public float impulseStrength;

		public float recoilStrength;

		public float fireAnimationTime;

		public float attackCooldown;

		public float range;

		public float radius;

		public int fireSoundEffect;

		public int hitSoundEffect;
	}

	[CompilerGenerated]
	private sealed class _003CDisableAnimatorCoroutine_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemEditable _003C_003E4__this;

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
		public _003CDisableAnimatorCoroutine_003Ed__42(int _003C_003E1__state)
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
	protected Transform weaponParent;

	[SerializeField]
	protected Transform weaponHandle;

	[SerializeField]
	protected Transform cubeModelParent;

	[SerializeField]
	protected AudioSource fireAudioSource;

	[SerializeField]
	protected AudioSource hitAudioSource;

	[SerializeField]
	protected Animator animator;

	[SerializeField]
	protected AudioClip[] fireAudioClips;

	[SerializeField]
	protected AudioClip[] hitAudioClips;

	protected int hitLayerMask;

	protected GameObject cubeModelObject;

	private IEnumerator animatorRoutine;

	public int CubeModelPid { get; private set; }

	protected virtual string FireSoundEffectName => null;

	protected virtual string HitSoundEffectName => null;

	protected virtual string AttackAnimationName => null;

	protected EditableItemConfiguration Configuration { get; set; }

	public abstract bool IsSameItemData(Dictionary<object, object> itemData);

	protected abstract void SetConfiguration(Dictionary<object, object> data);

	protected abstract EditableItemConfiguration GetDefaultConfiguration();

	private void Awake()
	{
	}

	protected virtual void Initialize()
	{
	}

	private void SetValuesBasedOnConfiguration()
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	protected void OnCubeModelStateChanged()
	{
	}

	protected virtual void SetAnimation()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	protected void PlayAnimation()
	{
	}

	protected virtual void OnHit(List<VoxelHit> voxelHits, Ray lineOfFire)
	{
	}

	protected void OnHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	protected void OnLocalHit(List<VoxelHit> voxelHits, Ray lineOfFire)
	{
	}

	private void OnLocalHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	protected void PlayAudio(AudioSource audioSource, string soundEffectName, Vector3 position, bool useAudioManager = true)
	{
	}

	[IteratorStateMachine(typeof(_003CDisableAnimatorCoroutine_003Ed__42))]
	private IEnumerator DisableAnimatorCoroutine()
	{
		return null;
	}

	private void DisableAnimation()
	{
	}

	protected bool IsSamePickupItem(Dictionary<object, object> itemData)
	{
		return false;
	}

	protected virtual void InterruptFire()
	{
	}

	public override void OnUnequip()
	{
	}

	protected override void OnHolstered()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}
}
