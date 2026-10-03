using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.JetPack;
using WorldObjectTypes.VehicleEnergy;
using WorldObjectTypes.VehiclesBase.Shared;

public class MVJetPack : MVVehicleBase
{
	public enum JetModeType : byte
	{
		Off = 0,
		On = 1,
		Overheating = 2,
		NotSet = 3
	}

	public enum JetPackType : byte
	{
		JetPack = 0,
		JetPackDeluxe = 1
	}

	protected class LocalObjectsJetPack : LocalObjectsBase
	{
		private float thrustTimeOverheatThreshold;

		private float thrustTimeWarning;

		private float thrustTime;

		private float coolDownFactor;

		private JetPackMotor vehicleMotor;

		private MVJetPack owner;

		private MVTriggerHandler triggerHandler;

		private MVPickupOwner avatarPickupOwner;

		private bool walkMode;

		private bool leaveMode;

		private SmoothCharacterController avatarController;

		private Camera mainCamera;

		private JetPackVisualization jetPackVisualization;

		private MVAvatarLocal vehicleUser;

		private bool wasFiring;

		private int framesGrounded;

		private int framesGroundedThreshold;

		public override int Id => 0;

		protected override MVVehicleBase Owner => null;

		public LocalObjectsJetPack(MVJetPack vehicleBase, MVAvatarLocal vehicleUser, JetPackParameters jetPackTypeParameters, VehicleSeatBase seat)
		{
		}

		private void OnFiring(bool isFiring)
		{
		}

		public override void Destroy()
		{
		}

		public override void Leave()
		{
		}

		public override InputToInGameAction Update(InputToInGameAction interactionInput)
		{
			return null;
		}

		public override void Enter()
		{
		}

		public override IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap)
		{
			return null;
		}

		public override void RefillEnergy(VehicleEnergyRefill vehicleEnergyRefill)
		{
		}

		public override bool UsesEnergy()
		{
			return false;
		}

		public override void RollbackVehicleRefillEnergyPrediction(int spawnerId)
		{
		}

		private bool WalkMode(bool thrust)
		{
			return false;
		}

		private bool EvaluateThrust(bool thrust)
		{
			return false;
		}

		private void OverheatUpdate(bool thrust)
		{
		}

		private Quaternion FiringDirectionRotation()
		{
			return default;
		}

		public IInputToPlayerMovement HandleWalkMode(IInputToPlayerMovement movementMap)
		{
			return null;
		}
	}

	private CullingSubscriberDynamic cullingSubscriberDynamic;

	private EditableCubeModelWrapper editableCubeModelWrapper;

	private MVRuntimeDataVariableClampedFloat shield;

	public MVRuntimeDataVariableClampedFloat Health;

	public MVRuntimeDataVariable Modifiers;

	public MVRuntimeDataVariable JetMode;

	private JetPackParameters jetPackParameters;

	private JetPackType jetPackType;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVRuntimeDataVariableClampedFloat Shield
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MVJetPack(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	protected override VehicleEnergyContainerConfig SetupVehicleEnergyContainerConfig()
	{
		return default;
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	public override void Destroy()
	{
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}

	protected override void VehicleEntered(MVAvatar vehicleUser, int seatID)
	{
	}

	protected override LocalObjectsBase CreateLocalObjects(int seatID, MVAvatarLocal vehicleUser)
	{
		return null;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	private void OnIsDeadChange(object isDead)
	{
	}

	private static JetPackType GetJetPackType(Dictionary<object, object> data)
	{
		return JetPackType.JetPack;
	}

	private static VehicleBaseObject GetPickupPrefabName(Dictionary<object, object> data)
	{
		return null;
	}
}
