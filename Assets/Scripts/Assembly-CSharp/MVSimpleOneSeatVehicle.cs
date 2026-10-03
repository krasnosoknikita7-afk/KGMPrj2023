using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;
using WorldObjectTypes.VehiclesBase.Shared;

public abstract class MVSimpleOneSeatVehicle : MVVehicleBase, ICurrentItemOwner
{
	protected class LocalObjectsSimpleVehicle : LocalObjectsBase
	{
		protected VehiclePickupOwner pickupOwner;

		protected PickupGUI pickupGUI;

		protected MVTriggerHandler triggerHandler;

		protected SimpleVehicleMotorBase vehicleMotor;

		private MVSimpleOneSeatVehicle owner;

		public override int Id => 0;

		protected override MVVehicleBase Owner => null;

		public LocalObjectsSimpleVehicle(MVSimpleOneSeatVehicle vehicleBase, SmoothCharacterController smoothController, SimpleVehicleMotorBase motor)
		{
		}

		public override void Destroy()
		{
		}

		public override void Leave()
		{
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

		public override InputToInGameAction Update(InputToInGameAction interactionInput)
		{
			return null;
		}
	}

	public MVRuntimeDataVariableClampedFloat Health;

	public MVRuntimeDataVariable Modifiers;

	public MVRuntimeDataVariable CurrentItem;

	public MVRuntimeDataVariable IsFiring;

	private MVRuntimeDataVariableClampedFloat shield;

	protected EditableCubeModelWrapper editableCubeModelWrapper;

	protected float maxHealth;

	protected float previousHealth;

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

	protected MVSimpleOneSeatVehicle(Dictionary<object, object> data, VehicleBaseObject _vehiclePrefab, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
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

	public Dictionary<object, object> GetCurrentItemState()
	{
		return null;
	}

	public void SetCurrentItemState(Dictionary<object, object> aNewState)
	{
	}
}
