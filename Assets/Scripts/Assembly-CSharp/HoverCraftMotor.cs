using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public class HoverCraftMotor : SimpleVehicleMotorBase
{
	private Vector3 velocityPrevFrame;

	private BounceState bounceState;

	public float thrustFactor;

	public const int DefaultSpeed = 8;

	public static readonly List<float> speedDragXZMap;

	private float dragCoefficientXZFromInit;

	public float dragCoefficientXZ;

	public float dragCoefficentUp;

	public float dragCoefficentDown;

	public float mass;

	public const float MinAngularSpeed = 0.5f;

	public const float MaxAngularSpeed = 6f;

	public const float DefaultAngularSpeed = 3.4f;

	public float angularSpeed;

	public const bool DefaultVehicleEnergyOn = false;

	public const int DefaultVehicleEnergyStorage = 55;

	public const int MinVehicleEnergyStorage = 10;

	public const int MaxVehicleEnergyStorage = 110;

	public const int DefaultVehicleEnergyConsumption = 6;

	public const int MinVehicleEnergyConsumption = 1;

	public const int MaxVehicleEnergyConsumption = 15;

	private const float OutOfEnergyAccelerationMax = 6.9f;

	private const float OutOfEnergyAccelerationMin = -6.9f;

	private const float MagnitudeDivider = 8f;

	private const float FrictionFactor = 10f;

	private const float HullRotationFactorClassic = 20f;

	private const float RecalibrateCameraFactor = 1.25f;

	private const string Horizontal = "Horizontal";

	private const float DriftCorrectionRotation = 10f;

	private const float VerticalThrustTime = 0.6f;

	private float availableVerticalThrustTime;

	private bool wasJumping;

	private const float StoppedJumpingTimeOut = 0.3f;

	private float stoppedJumpingTime;

	private const float RegenerationFactor = 0.6f;

	private bool isVerticalThrusting;

	public const float DefaultJumpForce = 4f;

	public const float MaxJumpForce = 20f;

	public const float MinJumpForce = 0f;

	private float jumpForce;

	public override Vector3 Velocity => default;

	public override bool IsMovementLocked { get; set; }

	public override void Init(SmoothCharacterController characterController, VehicleInteractable interactableLocalParam, VehicleEnergyContainerConfig vehicleEnergyContainerConfig)
	{
	}

	public override void Reset()
	{
	}

	public override void OnLocalVehicleLeave()
	{
	}

	public override void OnLocalVehicleEnter()
	{
	}

	public override void VehicleUpdateFunction()
	{
	}

	private Vector3 GetVehicleVelocity(Vector3 velocity, Vector3 baseVelocity)
	{
		return default;
	}

	private Vector3 GetVehicleInputVelocity(Vector3 velocity)
	{
		return default;
	}

	private Vector3 GetVehicleInputVelocityClassicCam(Vector3 velocity)
	{
		return default;
	}

	private Vector3 PlatformerDriftCorrection(Vector3 velocity, Vector3 targetDir)
	{
		return default;
	}

	public static Vector3 RotateTowardsAroundY(Vector3 vec, Vector3 target, float speedInDegrees)
	{
		return default;
	}

	private static Vector3 HoverCraftFrictionXZ(Vector3 velocity)
	{
		return default;
	}

	private Vector3 XZDrag(Vector3 velocityNormal, float velocitySquareMagnitude)
	{
		return default;
	}

	private Vector3 HullRotationDrag(Vector3 velocityNormal, float velocitySquareMagnitude, float hullRotationFactor)
	{
		return default;
	}

	private Vector3 VerticalDrag(Vector3 velocityNormal, float velocitySquareMagnitude)
	{
		return default;
	}

	private Vector3 HandleVerticalThrust(Vector3 velocity)
	{
		return default;
	}

	private float DragCoefficientXZHullRotationFactor(Vector3 velocity, float hullRotationFactor)
	{
		return 0f;
	}

	public void UpdateConfiguration(Dictionary<object, object> data)
	{
	}
}
