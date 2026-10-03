using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class PickupItemModelGun : PickupItemWithDelay
{
	[CompilerGenerated]
	private sealed class _003CDoAutoFire_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemModelGun _003C_003E4__this;

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
		public _003CDoAutoFire_003Ed__39(int _003C_003E1__state)
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

	public float minDistanceToCubeFire;

	public int ammo;

	public RailRay railGunRayPrefab;

	public float speed;

	public float range;

	public Transform chargeObject;

	public float fireIntervalSecondary;

	public Bullet rocketPrefab;

	public GUICellCursor primaryCursor;

	public GUICellCursor secondaryCursor;

	public AudioClip cubeLandedSound;

	public AudioClip chargeSound;

	public AudioClip releaseSound;

	public AudioClip cubeDestroyedSound;

	public AudioClip firePrimary;

	private float prevFireTime;

	private byte material;

	private bool waitingToFire;

	private int currentAmmo;

	private bool fireMain;

	private bool fireSecondary;

	public CubeBullet cubeBullet;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	protected override bool IsAmmoDepleted => false;

	private void Update()
	{
	}

	private bool DoLineOfFireCheck(out VoxelHit hit)
	{
		hit = default;
		return false;
	}

	private bool CanInsertCubeAtCubePos(IntVector cubePos)
	{
		return false;
	}

	private void HandleCursors()
	{
	}

	public override void OnUnequip()
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	public override void ResetAmmo()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	protected void OnFireSecondary(bool isLocal)
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	private bool ShowCursors()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDoAutoFire_003Ed__39))]
	private IEnumerator DoAutoFire()
	{
		return null;
	}

	private bool GetCubePosFromFineGrainedTerrain(VoxelHit voxelHit, float maxDistanceToEdge, ref IntVector pos)
	{
		return false;
	}

	private void HandleCubeHitLocal(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void HandleCubeHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private IntVector GetCubePos(VoxelHit voxelHit)
	{
		return default;
	}
}
