using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public class HamsterWheelMotor : SimpleVehicleMotorBase
{
	private HamsterWheelBounceState bounceState;

	private JumpState jumpState;

	private Vector3 curVelocity;

	private float speed;

	private const float MaxSpeed = 38.8f;

	private const float MinSpeed = -10f;

	private const float AccelerationSpeed = 48f;

	private const float AngularSpeed = 1.4f;

	private const float RecalibrateCameraFactor = 1.05f;

	public const bool DefaultVehicleEnergyOn = false;

	public const int DefaultVehicleEnergyStorage = 35;

	public const int MinVehicleEnergyStorage = 10;

	public const int MaxVehicleEnergyStorage = 75;

	public const int DefaultVehicleEnergyConsumption = 4;

	public const int MinVehicleEnergyConsumption = 2;

	public const int MaxVehicleEnergyConsumption = 11;

	private MVInteractableBase interactable;

	public override Vector3 Velocity => default;

	public override bool IsMovementLocked { get; set; }

	public override void Init(SmoothCharacterController smoothCharacterController, VehicleInteractable interactableLocalParam, VehicleEnergyContainerConfig vehicleEnergyContainerConfig)
	{
	}

	public override void VehicleUpdateFunction()
	{
	}

	public override void Reset()
	{
	}

	private Vector3 GetVehicleVelocity(Vector3 velocity, Vector3 baseVelocity)
	{
		return default;
	}

	private Vector3 GetVehicleVelocityClassicCam(Vector3 velocity, Vector3 movableVelocity)
	{
		return default;
	}
}
