using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public class MVHamsterWheel : MVSimpleOneSeatVehicle
{
	protected class LocalObjectsHamsterWheel : LocalObjectsSimpleVehicle
	{
		public LocalObjectsHamsterWheel(MVHamsterWheel vehicle, SmoothCharacterController smoothController, SimpleVehicleMotorBase hamsterWheelMotor)
			: base(null, null, null)
		{
		}

		public override void Leave()
		{
		}

		public override IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap)
		{
			return null;
		}
	}

	private CullingSubscriberDynamic cullingSubscriberDynamic;

	private float deathExplosionDamageValue;

	private float deathExplosionRadius;

	private float deathExplosionImpulse;

	public MVRuntimeDataVariable IsMovingForward;

	private bool wasMovingForward;

	public MVRuntimeDataVariable IsMovingBackwards;

	private bool wasMovingBackwards;

	public MVRuntimeDataVariable IsGrounded;

	private bool wasGrounded;

	public override bool IsDead => false;

	public MVHamsterWheel(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
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

	public override void Destroy()
	{
	}

	private void OnIsDeadChange(object isDead)
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	protected override LocalObjectsBase CreateLocalObjects(int seatID, MVAvatarLocal vehicleUser)
	{
		return null;
	}
}
