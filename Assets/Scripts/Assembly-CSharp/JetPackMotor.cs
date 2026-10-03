using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public class JetPackMotor : MVRigidBody
{
	public struct JetPackMotorConfig
	{
		public AvatarInteractable interactableLocal;

		public VehicleInteractable vehicleInteractable;

		public SmoothCharacterController avatarController;

		public float thrustStrength;

		public float density;

		public VehicleEnergyContainerConfig vehicleEnergyContainerConfig;

		public float outOfEnergyThrustMax;
	}

	private const float VelocityConstant = 40f;

	private float thrust;

	private const float ThrustLeaveMode = 1000f;

	private const float LeaveModeForward = 4.5f;

	private readonly KeyValuePair<float, float> leaveModeRotationRange;

	private const float RunSpeed = 12f;

	private const float SpeedSmoothing = 10f;

	private float speed;

	private readonly AnimationCurve slopeSpeedMultiplier;

	private Vector3 velocityPrevFrame;

	private BounceState bounceState;

	private MVMovableMotorState movableMotorState;

	private readonly ImpactState impactState;

	private MVInteractableBase interactable;

	private MVInteractableBase vehicleInteractable;

	private const float JetpackAirFriction = 0.43f;

	private float waterProximity;

	private SmoothCharacterController smoothController;

	protected StuckEvaluator stuckEvaluator;

	public const bool DefaultVehicleEnergyOn = false;

	public const int DefaultVehicleEnergyStorage = 20;

	public const int MinVehicleEnergyStorage = 4;

	public const int MaxVehicleEnergyStorage = 45;

	public const int DefaultVehicleEnergyConsumption = 3;

	public const int MinVehicleEnergyConsumption = 1;

	public const int MaxVehicleEnergyConsumption = 8;

	private float thrustOutOfEnergyMax;

	private VehicleEnergyContainer vehicleEnergyContainer;

	private bool leaveMode;

	private MvCharacterController Controller => null;

	public bool IsUnderWater => false;

	public override Vector3 Velocity => default;

	public Vector3 Impulses => default;

	public Vector3 InputMoveDirection { get; set; }

	public bool Thrust { get; set; }

	public bool InputRun { get; set; }

	public bool LeaveMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool Grounded => false;

	public float WaterProximity => 0f;

	public override bool IsMovementLocked { get; set; }

	public bool OutOfEnergy => false;

	protected override void SuspendImpactDamage()
	{
	}

	public List<MVOverlapResult> GetOverlappingObjects()
	{
		return null;
	}

	public bool IsStuck()
	{
		return false;
	}

	public void Init(MVRuntimeDataVariable jetMode, JetPackMotorConfig jetPackMotorConfig)
	{
	}

	private void OnJetModeChange(MVJetPack.JetModeType jetModeType)
	{
	}

	public void FrameUpdate()
	{
	}

	public void FixedUpdateFunction(Quaternion setQuaternion, bool shouldSetRotation)
	{
	}

	private Vector3 GetVelocity(Vector3 velocity, Vector3 baseVelocity)
	{
		return default;
	}

	private void ApplyJetImpulse(float jetpackThrust)
	{
	}

	protected void DealImpactDamage(Vector3 curVelocity, Vector3 prevVelocity)
	{
	}

	private GroundChange Move(Vector3 velocity, Vector3 baseVelocity)
	{
		return GroundChange.UnChanged;
	}

	private Vector3 ApplyInputVelocityChange(Vector3 velocity, Vector3 baseVelocity)
	{
		return default;
	}

	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default;
	}

	public void RefillEnergy(VehicleEnergyRefill vehicleEnergyRefill)
	{
	}

	public bool UsesEnergy()
	{
		return false;
	}

	public void RollbackRefillEnergyPrediction(int spawnerId)
	{
	}
}
