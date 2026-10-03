using System.Collections.Generic;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;
using UnityEngine;

public class MVBuildModeAvatarLocal : MVBuildModeAvatar, ILocalObject, ISpawnRoleLocal
{
	public enum AvatarBuildModes : byte
	{
		None = 0,
		Edit = 1
	}

	public abstract class AvatarBuildModeBase
	{
		protected readonly MVBuildModeAvatarLocal buildModeAvatar;

		public abstract AvatarBuildModes AvatarBuildModeRuntimeState { get; }

		public abstract void Activate(AvatarBuildModes fromMode);

		public abstract void DeActivate(AvatarBuildModes toMode);

		public abstract void FixedUpdate(IInputToPlayerMovement movementMap);

		public abstract void FrameUpdate(InputToInGameAction interactionMap);

		protected AvatarBuildModeBase(MVBuildModeAvatarLocal buildModeAvatar)
		{
		}
	}

	public class EditMode : AvatarBuildModeBase
	{
		public class CERoamUUISetupData
		{
			public readonly Vector3 centerPos;

			public readonly Vector3 lookAtPosition;

			public CERoamUUISetupData(Vector3 centerPos, Vector3 lookAtPosition)
			{
			}
		}

		public class EditCubesSetupData
		{
			public readonly int focusWoId;

			public EditCubesSetupData(int focusWoId)
			{
			}
		}

		public class CEEditBodyUUIData
		{
			public readonly int focusWoId;

			public CEEditBodyUUIData(int focusWoId)
			{
			}
		}

		public class ESEditCubeTutorialData
		{
			public readonly int focusWoId;

			public ESEditCubeTutorialData(int focusWoId)
			{
			}
		}

		private AvatarBuildModes _avatarBuildModeRuntimeState;

		private const float pitchSensitivity = 0.167f;

		private const float yawSensitivity = 0.208f;

		private const float basePitch = 20f;

		private const float minimumY = -60f;

		private const float maximumY = 60f;

		private readonly float maxSpeed;

		private readonly float speedModifier;

		private Vector3 jetPackTargetDeltaPos;

		private float targetSpeed;

		private float speed;

		private float speedSmoothingTime;

		private bool moveConstraintSet;

		private Vector3 moveConstraintCenter;

		private float moveConstraintRadius;

		private const float moveSlowDownPoint = 0.75f;

		private DoubleTapMovementChecker doubleTap;

		private Camera mainCamera;

		private float keyVelocity;

		private float keyAcceleration;

		private float keyDamping;

		private readonly float heightAdjustSpeed;

		public override AvatarBuildModes AvatarBuildModeRuntimeState => AvatarBuildModes.None;

		private float YMovementSpeedScale { get; set; }

		private float XZMovementSpeedScale { get; set; }

		public bool MovementConstrained
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public EditMode(MVBuildModeAvatarLocal buildModeAvatar)
			: base(null)
		{
		}

		public override void Activate(AvatarBuildModes fromMode)
		{
		}

		private void SetCamera(CameraType cameraType)
		{
		}

		private void AvatarCommandsBuildModeOnOnSetSpawn(Vector3 position, Quaternion rotation)
		{
		}

		public override void DeActivate(AvatarBuildModes toMode)
		{
		}

		public void ModifySpeed(float xz, float y)
		{
		}

		public override void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public override void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public void SetMoveConstraint(Vector3 center, float radius)
		{
		}

		private void TouchRotationToCamera()
		{
		}

		private void UpdateRotationToCamera()
		{
		}

		protected void SetToEditMode()
		{
		}

		private void MoveCharacter(Vector3 moveDelta)
		{
		}

		protected Vector3 GetElevationVelocity()
		{
			return default;
		}

		private void Move(Vector3 velocity)
		{
		}

		private Vector3 GetDirection(bool freeFlight)
		{
			return default;
		}

		private static Vector3 GetTouchInputDirection()
		{
			return default;
		}

		private static Vector3 GetInputDirection()
		{
			return default;
		}

		private Vector3 GetMovementVelocity()
		{
			return default;
		}

		private void AvatarCommandsBuildModeOnEnterBuildStateEvent(EditorEvent editorEvent, object data)
		{
		}

		private void ESLeaveCubeTutorialSetup()
		{
		}

		private void FocusOnPosition()
		{
		}

		private void ESEditCubeTutorialSetup(ESEditCubeTutorialData data)
		{
		}

		private void AvatarCommandsBuildModeOnExitBuildStateEvent(EditorEvent editorEvent, object data)
		{
		}

		private void EditCubesExitSetup()
		{
		}

		private void ESEditCubeTutorialExitSetup()
		{
		}

		private void CERoamUUIExitSetup()
		{
		}

		private void CEEditBodyUUIExitSetup()
		{
		}

		private void CEEditBodyUUIEnterSetup(CEEditBodyUUIData data)
		{
		}

		private void CERoamUUIEnterSetup(CERoamUUISetupData data)
		{
		}

		private void EditCubesDataEnterSetup(EditCubesSetupData data)
		{
		}
	}

	public class BuildModeAvatarLocalModes
	{
		private AvatarBuildModeBase currentMode;

		private MVBuildModeAvatarLocal avatar;

		public BuildModeAvatarLocalModes(MVBuildModeAvatarLocal avatar)
		{
		}

		public void FrameUpdate(InputToInGameAction interactionMap)
		{
		}

		public void FixedUpdate(IInputToPlayerMovement movementMap)
		{
		}

		public void SetMode(AvatarBuildModes mode)
		{
		}

		private AvatarBuildModeBase BuildModeFactory(AvatarBuildModes avatarBuildModeRuntimeState)
		{
			return null;
		}
	}

	protected SpawnRoleDataReceiver spawnRoleDataReceiver;

	private AvatarLocalBuildMode avatarScriptObject;

	private BuildModeAvatarLocalModes buildModeAvatarLocalModes;

	private LaserPointer laserPoint;

	int ILocalObject.Id => 0;

	int ISpawnRoleLocal.Id => 0;

	public MVBuildModeAvatarLocal(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public void Activate(int idFrom, SpawnRoleDataReceiver spawnRoleDataReceiver, Vector3 position, Quaternion rotation)
	{
	}

	public void Suspend()
	{
	}

	public void UnSuspend()
	{
	}

	public void DeActivate(int idTo, SpawnRoleDataReceiver spawnRoleDataReceiver)
	{
	}

	public InputToInGameAction Update(InputToInGameAction movementMap)
	{
		return null;
	}

	public IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap)
	{
		return null;
	}

	private void SetCamera(CameraType cameraType)
	{
	}

	private void SetToSpawn()
	{
	}

	private void HideEditCube()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void OnScaleChanged(MVWorldObjectClient wo, ScaleChangedEventArgs scaleChangedEventArgs)
	{
	}

	protected override Vector3 GetLookDirection()
	{
		return default;
	}
}
