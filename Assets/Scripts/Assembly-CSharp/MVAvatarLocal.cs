using System;
using System.Collections.Generic;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;
using Assets.Scripts.Tools;
using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using MV.WorldObject.MetaData;
using UnityEngine;

public class MVAvatarLocal : MVAvatar, ILocalObject, IBulletImpactVisualizer, ICurrentItemOwner, ISpawnRoleLocal
{
	private class AvatarLocalModes
	{
		private readonly Dictionary<AvatarRuntimeState, AvatarMode> avatarModes;

		private AvatarMode currentMode;

		private AvatarRuntimeState currentState;

		public AvatarMode CurrentMode => null;

		public AvatarRuntimeState CurrentState => AvatarRuntimeState.Hidden;

		public AvatarLocalModes(MVAvatarLocal avatar)
		{
		}

		public void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public void SetMode(AvatarRuntimeState mode)
		{
		}

		public void SetToStartMode()
		{
		}

		private AvatarRuntimeState GetStartState()
		{
			return AvatarRuntimeState.Hidden;
		}

		public bool HasDied()
		{
			return false;
		}
	}

	public abstract class AvatarMode
	{
		protected readonly MVAvatarLocal mvAvatar;

		public int modeTypes;

		public abstract void DeActivate(AvatarRuntimeState toMode);

		public abstract void FixedUpdate(IInputToPlayerMovement movementMap);

		public abstract void FrameUpdate(InputToInGameAction interactionMap);

		protected AvatarMode(MVAvatarLocal mvAvatar, int modeTypes)
		{
		}

		public virtual void Activate(AvatarRuntimeState fromMode)
		{
		}

		private void SetModeTypes()
		{
		}
	}

	protected class DeadMode : AvatarMode
	{
		private class AvatarInputControllerDead : IMotorAPI
		{
			private Quaternion rot;

			public Vector3 Direction
			{
				get
				{
					return default;
				}
				set
				{
				}
			}

			public Quaternion Rotation
			{
				get
				{
					return default;
				}
				set
				{
				}
			}

			public bool Jump => false;
		}

		protected float deadTime;

		protected float deadInterval;

		private bool setDeadCamDelayed;

		private readonly AvatarInputControllerDead inputController;

		public DeadMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		private void HandleDeathBriefingPause(int localPlayerActorNr, int dmgDealerActorNr, PlayerKilledByType damageType)
		{
		}

		private void HandleDeathBriefingPause()
		{
		}

		private void HandleResetUIPause()
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public bool HasDied()
		{
			return false;
		}

		private void RevivePlayer()
		{
		}

		private void OnEnterEditMode()
		{
		}
	}

	public abstract class EditAvatarModeBase : AvatarMode
	{
		protected EditAvatarModeBase(MVAvatarLocal mvAvatar, int modeTypes)
			: base(null, 0)
		{
		}

		protected void SetToEditMode()
		{
		}
	}

	public class GhostMode : AvatarMode
	{
		private bool haveSetTransparency;

		public GhostMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		private void ResetCamera()
		{
		}

		private void SendNotification()
		{
		}

		private void OnEnterEditMode()
		{
		}

		private IAvatarInputController CreateInputController()
		{
			return null;
		}
	}

	protected class LobbyMode : AvatarMode
	{
		public LobbyMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}
	}

	protected class ReviveMode : AvatarMode
	{
		private class AvatarInputControllerDead : IMotorAPI
		{
			private Quaternion rot;

			public Vector3 Direction
			{
				get
				{
					return default;
				}
				set
				{
				}
			}

			public Quaternion Rotation
			{
				get
				{
					return default;
				}
				set
				{
				}
			}

			public bool Jump => false;
		}

		protected float deadTime;

		protected float reviveInterval;

		private bool reviveElapsed;

		private bool setDeadCamDelayed;

		private AvatarInputControllerDead inputController;

		public ReviveMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		private void NoButtonPressed()
		{
		}

		private void OnEnterEditMode()
		{
		}
	}

	protected class ReviveWaitMode : AvatarMode
	{
		public ReviveWaitMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}
	}

	public class TimeAttackFlagDebriefingMode : AvatarMode
	{
		private readonly IAvatarInputController avatarInputController;

		private bool isInDebriefing;

		private Transform flagTransform;

		private Quaternion currentDirectionRotation;

		private float lastAngle;

		private float directionInterpolationStartTime;

		private const float walkAroundFlagAngle = 80f;

		private const float walkFromFlagAngle = 100f;

		private const float walkTowardsFlagAngle = 20f;

		private const float walkAroundCircleMinRadius = 1f;

		private const float walkAroundCircleMaxRadius = 1.3f;

		private const float maxFallBelow = 200f;

		private const float interpolationDuration = 0.4f;

		public TimeAttackFlagDebriefingMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		private IAvatarInputController CreateInputController()
		{
			return null;
		}

		private Transform GetClosestTimeAttackFlag()
		{
			return null;
		}

		private Vector3 GetAvatarMoveDirection()
		{
			return default;
		}

		private Vector3 RotateDirection(Vector3 direction, float angle)
		{
			return default;
		}

		private void OnEnterTimeAttackFlagDebriefing(int score)
		{
		}

		private void OnExitTimeAttackFlagDebriefing()
		{
		}

		private void DieByFalling()
		{
		}
	}

	protected class WaitMode : AvatarMode
	{
		private readonly IAvatarInputController avatarInputController;

		public WaitMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		private void ResetCamera()
		{
		}

		private void SendNotification()
		{
		}

		private IAvatarInputController CreateInputController()
		{
			return null;
		}
	}

	protected class WalkMode : AvatarMode
	{
		private const float maxFallBelow = 200f;

		private const float respawnTimeOut = 2f;

		private readonly IAvatarInputController avatarInputController;

		private bool isFiring;

		private bool isJumping;

		private readonly AvatarSound avatarSound;

		private readonly float swimStartProximity;

		private float prevWaterProximity;

		private bool IsSwimming => false;

		public WalkMode(MVAvatarLocal mvAvatar)
			: base(null, 0)
		{
		}

		public override void Activate(AvatarRuntimeState fromMode)
		{
		}

		public override void DeActivate(AvatarRuntimeState toMode)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		private void HandlePickupUpdate(InputToInGameAction interactionMap)
		{
		}

		private bool IsInJetpack()
		{
			return false;
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		private void HandleFocus()
		{
		}

		private void HandleStuck()
		{
		}

		private void DieByFalling()
		{
		}

		private void OnHandleFiring(bool isFiring)
		{
		}

		private void HandleWaterplane()
		{
		}

		private void SetAnimationState(Vector3 moveDirection)
		{
		}

		private IAvatarInputController CreateInputController()
		{
			return null;
		}
	}

	public Action<float, MVPlayer, PlayerKilledByType> OnDamageTaken;

	protected SpawnRoleDataReceiver spawnRoleDataReceiver;

	private string currAnim;

	private const float exitVehicleMomentumModifier = 7f;

	private AvatarMotor avatarMotor;

	private AvatarInteractable interactableLocal;

	private UseInteractorHandler useInteractorHandler;

	private MVTriggerHandler triggerHandler;

	private AvatarEquipable avatarEquipable;

	private AvatarPickupOwner pickupOwner;

	private PickupGUI pickupGUI;

	private MVRigidBody vehicleRigidBody;

	private AvatarLocalModes avatarLocalModes;

	private AvatarRespawnHandler avatarRespawnHandler;

	private Action<int, int, PlayerKilledByType> OnKilled;

	private Action OnSuicide;

	private float previousHealth;

	private float previousShield;

	private float boostedHealthMultiplier;

	private int defaultBaseMaxHealth;

	private bool suspended;

	private int spawnWorldObjectId;

	private Vector3 LookAtPos => default;

	public AvatarInteractable InteractableLocal => null;

	public override Vector3 VelocityAbsolute => default;

	public AvatarPickupOwner PickupOwner => null;

	public bool ForceRotateAvatarToFiringDirection { private get; set; }

	public MVRigidBody RigidBody => null;

	public bool IsEnteringVehicle => false;

	public bool IsInVehicle => false;

	public Bounds Bounds => default;

	public ColliderCollection TriggingColliders => null;

	public AvatarMotor AvatarMotor => null;

	public bool InGunMode => false;

	public override Vector3 VelocityRelative => default;

	public KogamaSettingWrapperBase Settings => null;

	public int BaseMaxHealth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private AvatarLocal AvatarLocal => null;

	public int SpawnId
	{
		private get
		{
			return 0;
		}
		set
		{
		}
	}

	int ILocalObject.Id => 0;

	int ISpawnRoleLocal.Id => 0;

	public MVAvatarLocal(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public bool IsSpawnRoleActive()
	{
		return false;
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool HasDied()
	{
		return false;
	}

	public float GetColliderRadius()
	{
		return 0f;
	}

	public override void Initialize()
	{
	}

	private void OnResume()
	{
	}

	private void OnObserve()
	{
	}

	public void Activate(int idFrom, SpawnRoleDataReceiver spawnRoleDataReceiver, Vector3 position, Quaternion rotation)
	{
	}

	private void SubscribeToExternalEvents()
	{
	}

	private void UnsubscribeFromExternalEvents()
	{
	}

	public void DeActivate(int idTo, SpawnRoleDataReceiver spawnRoleDataReceiver)
	{
	}

	private void SetupSpawnroleReceiver(SpawnRoleDataReceiver spawnRoleDataReceiver)
	{
	}

	public void Suspend()
	{
	}

	public void UnSuspend()
	{
	}

	public void SetMode(AvatarRuntimeState localMode)
	{
	}

	public void SetCharacterController(SmoothCharacterController characterController)
	{
	}

	public void LeaveVehicle(bool leaveBecauseOfServer)
	{
	}

	public override void BeforeVehicleEntered()
	{
	}

	public override void OnEnterVehicle()
	{
	}

	public override void OnLeaveVehicle()
	{
	}

	public InputToInGameAction Update(InputToInGameAction interactionMap)
	{
		return null;
	}

	public IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap)
	{
		return null;
	}

	public Dictionary<object, object> GetCurrentItemState()
	{
		return null;
	}

	public void SetCurrentItemState(Dictionary<object, object> aNewState)
	{
	}

	public void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage = 100f)
	{
	}

	public void SetAnimation(string animationState)
	{
	}

	protected override void OnSeatedChanged(bool isSeated)
	{
	}

	protected override void AvatarStateChangedHandler(object a)
	{
	}

	protected override void AttachBody(MVBody newBody)
	{
	}

	private void AvatarCommandsPlayModeOnOnRemoveFromGame()
	{
	}

	private void AvatarCommandsPlayModeOnOnWinningConditionIntermediateDebriefing(WinningConditionType winningConditionType)
	{
	}

	private void AvatarCommandsOnSetToSpawnPoint()
	{
	}

	private void AvatarCommandsPlayModeOnOnSpawn()
	{
	}

	private void AvatarCommandsOnRespawn()
	{
	}

	private void AvatarCommandsOnSetToSpawnMode()
	{
	}

	private void AvatarCommandsPlayModeOnOnReadyScreenShot()
	{
	}

	private void GameStateTypeOnOnChange(MVGameStateType gameStateType)
	{
	}

	private void GameEventManagerOnOnXpRewarded(int obj)
	{
	}

	private void OnSetRespawnWhenPossible()
	{
	}

	private void OnSetSpawnAsGhost()
	{
	}

	private void OnSetToDeadMode()
	{
	}

	private void GameEventManagerOnOnFirstTimeEvent(FirstTimeEvent firstTimeEvent)
	{
	}

	private void OnHolsteredChanged(bool obj)
	{
	}

	private void OnUnequip(object sender, EventArgs e)
	{
	}

	public bool IsEquipped(AvatarItemType avatarItemType)
	{
		return false;
	}

	private void KillSelf()
	{
	}

	private void SetToSpawnTransform()
	{
	}

	private void ResetAvatar()
	{
	}

	private int GetBoostedHealth(int unBoostedMaxHealth)
	{
		return 0;
	}

	private void OnHealthBoostedChanged()
	{
	}

	private void UpdateMaxHealth()
	{
	}

	private void Die()
	{
	}

	private void OnRespawn()
	{
	}

	private void SetTransform(Vector3 position, Quaternion rotation)
	{
	}

	private void InitializeShield()
	{
	}

	private void OnDisableVehicles(object sender, EventArgs args)
	{
	}

	private void OnCameraScale(object sender, ScaleArgs args)
	{
	}

	private void InitializeHealth()
	{
	}

	private void Suicide()
	{
	}

	private Vector3 CalculateVehicleExitMomentum(Vector3 velocity)
	{
		return default;
	}

	private void RelayDamageEvent(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	private void RelayNewSafePosition(Vector3 lastSafePosition)
	{
	}

	private void AvatarCommandsOnMoveBodyToSafeSpot(int safeSpotIndex)
	{
	}

	private void AvatarCommandsOnSpawnAtSafeSpot(int safeSpotIndex)
	{
	}

	private void OnEquipItem(PickupItem equippeditem)
	{
	}

	private Transform GetSpawnTransform()
	{
		return null;
	}

	private void OnCheckpointReachedResetRevive()
	{
	}

	private bool IsInTempTier()
	{
		return false;
	}

	private GamePassTier GetTierRequirement()
	{
		return GamePassTier.Tier0;
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void OnRotationChanged(MVWorldObjectClient wo, RotationChangedEventArgs rotationChangedEventArgs)
	{
	}

	private void OnScaleChanged(MVWorldObjectClient wo, ScaleChangedEventArgs scaleChangedEventArgs)
	{
	}

	protected override void OnCurrentPickupChange(object newPickupDataData)
	{
	}

	private void HandleBlinkerVisibility()
	{
	}
}
