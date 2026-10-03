using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickUpItemHealRay : PickupItem
{
	private struct RayCastData
	{
		public enum RayCastStatus
		{
			StopRay = 0,
			StartRay = 1,
			ContinueRay = 2
		}

		public RayCastStatus Status;

		public VoxelHit HitVoxel;

		public Vector3 Direction;
	}

	private float passedLerpTime;

	private Quaternion lerpStartRotation;

	[SerializeField]
	private ParticleSystem rayParticles;

	private ParticleSystem hitParticles;

	[SerializeField]
	private float maxRayRange;

	[SerializeField]
	private float maxLockOnRange;

	[SerializeField]
	private float rayMinimumChargeTime;

	[SerializeField]
	private AudioSource audioSource;

	private float rayStartTime;

	private GameObject stuckObject;

	private bool damageRay;

	private bool isLockedOn;

	private bool isShooting;

	private ObscuredFloat currentAmmoLeft;

	private const float updateWaitTime = 0.05f;

	private float elapsedUpdateWaitTime;

	private Vector3 hitOffset;

	[SerializeField]
	[Tooltip("How many seconds the healrays ammo lasts.")]
	private ObscuredFloat maxAmmoTime;

	private LayerMask layers;

	private const float hitGroundStartPositionMidifier = 0.6f;

	[SerializeField]
	private Material ZIgnoreMaterial;

	[SerializeField]
	private Transform localMuzzePoint;

	[SerializeField]
	private ParticleSystem localRayParticles;

	private Transform remoteMuzzlePoint;

	private ParticleSystem remoteParticleSystem;

	private Material normalRayMaterial;

	private ParticleSystemRenderer particleRenderer;

	private const string stuckObjectIDString = "S";

	private static readonly Color lockOnColorHealing;

	private static readonly Color lockOnColorDamaging;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void OnEquip()
	{
	}

	public override void OnUnequip()
	{
	}

	public override void ResetAmmo()
	{
	}

	private bool IsStillChargingRay()
	{
		return false;
	}

	private void DoHealing()
	{
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	private void ChangeUsedParticleSystem()
	{
	}

	private Vector3 CalculateParticlesRotation()
	{
		return default;
	}

	private void DoAmmoDepletion()
	{
	}

	private void DoFloating()
	{
	}

	private void Update()
	{
	}

	private void UpdateRaysVisualRepresentation()
	{
	}

	private void LerpRaysVisualRepresentation()
	{
	}

	public override void TriggerEnd()
	{
	}

	private RayCastData UpdateRaycastLocally(Vector3 direction)
	{
		return default;
	}

	private void UpdateRaycastRemotely(Vector3 direction)
	{
	}

	private void HandleRaycastResultLocally(RayCastData result)
	{
	}

	private void UpdateRayParticleEffect(VoxelHit hitVoxel, Vector3 direction)
	{
	}

	private Vector3 HandleVehicleHitPosition(Vector3 hitPosition, Vector3 direction, float hitDistance)
	{
		return default;
	}

	private void UpdateRayHealingLogic(VoxelHit hitVoxel)
	{
	}

	private InteractionDataHandlerBase HandleChildObjectHit(VoxelHit hitVoxel, InteractionDataHandlerBase interactionHandler)
	{
		return null;
	}

	private InteractionDataHandlerBase GetInteractionHandler(MVWorldObjectClient worldObject)
	{
		return null;
	}

	private void TryHealTarget(InteractionDataHandlerBase interactionHandler)
	{
	}

	private bool IsDirectionValid(Vector3 direction)
	{
		return false;
	}

	private List<VoxelHit> DoRaycast(Vector3 direction)
	{
		return null;
	}

	private VoxelHit CalculateClosestVoxelHit(List<VoxelHit> hitVoxels)
	{
		return default;
	}

	private Vector3 CalculateHitPosition(Vector3 fireFromPosition, Vector3 direction, float distance)
	{
		return default;
	}

	private void OnHitParticleUpdate(Vector3 hitPosition, Vector3 firingDirection, float distance)
	{
	}

	private void UpdateHitParticles(Vector3 firingDirection, Vector3 hitPosition)
	{
	}

	private void SetRayParticleDistance(float distance)
	{
	}

	private void HandleNoHit()
	{
	}

	private void HandleOnStuck(MVWorldObjectClient hitObject, RayCastData result)
	{
	}

	private bool IsObjectStuckable(MVWorldObjectClient hitObject)
	{
		return false;
	}

	private void CalculateHitOffset(VoxelHit hitVoxel, Vector3 direction)
	{
	}

	private void ShowHitEffect()
	{
	}

	private void UpdateStuckObject(MVWorldObjectClient hitObject)
	{
	}

	private void UpdateItemState(int stuckObjectId)
	{
	}

	private Vector3 CalculateStuckPosition()
	{
		return default;
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	private static bool IsDamageRay(MVPickupOwner shooter, MVWorldObjectClient stuckWorldObject)
	{
		return false;
	}

	private void SyncState(Dictionary<object, object> newState)
	{
	}

	private void ChangeValueInState(Dictionary<object, object> newState, string key, int value)
	{
	}

	private void ChangeValueInState(Dictionary<object, object> newState, string key, float value)
	{
	}

	private float GetMaxRange()
	{
		return 0f;
	}
}
