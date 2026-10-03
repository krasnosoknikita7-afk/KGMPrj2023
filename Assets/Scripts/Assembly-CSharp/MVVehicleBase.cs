using System;
using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;
using WorldObjectTypes.VehiclesBase.Shared;

public abstract class MVVehicleBase : MVBlueprintBase, IBulletImpactVisualizer
{
	protected struct HealthChangeAffects
	{
		public bool detachAvatar;

		public bool causeVehicleDestruction;
	}

	protected abstract class LocalObjectsBase : ILocalObject
	{
		public Action onDestroy;

		public Action onLeave;

		public Action onEnter;

		protected float timeBeforeUnregisterAfterDeath;

		protected List<Component> localComponents;

		public abstract int Id { get; }

		protected abstract MVVehicleBase Owner { get; }

		public List<T> GetLocalComponents<T>() where T : Component
		{
			return null;
		}

		public virtual void Destroy()
		{
		}

		public virtual void Enter()
		{
		}

		public virtual void Leave()
		{
		}

		public abstract InputToInGameAction Update(InputToInGameAction interactionInput);

		public abstract IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap);

		protected void OnHealthChange(object v)
		{
		}

		public abstract void RefillEnergy(VehicleEnergyRefill vehicleEnergyRefill);

		public abstract bool UsesEnergy();

		public abstract void RollbackVehicleRefillEnergyPrediction(int spawnerId);
	}

	protected MVWorldObjectDocumentationType documentationType;

	public MVRuntimeDataVariable IsVehicleDead;

	protected VehicleSeatManager seatManager;

	protected LocalObjectsBase localObjects;

	protected VehicleVisualizationBase visualization;

	protected VehicleBaseObject vehicleBaseObject;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public virtual bool IsDead => false;

	public virtual bool IsInSpawner { get; private set; }

	protected VehicleEnergyContainerConfig VehicleEnergyContainerConfig { get; }

	public VehicleVisualizationBase Visualization => null;

	protected MVVehicleBase(Dictionary<object, object> data, ObjectPrefab vehiclePrefab, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	protected abstract VehicleEnergyContainerConfig SetupVehicleEnergyContainerConfig();

	public override void OnDataUpdate()
	{
	}

	public override void Initialize()
	{
	}

	public void LeaveLocal()
	{
	}

	public void Enter(MVAvatar vehicleUser, int seatID)
	{
	}

	protected abstract LocalObjectsBase CreateLocalObjects(int seatID, MVAvatarLocal vehicleUser);

	protected virtual void VehicleEntered(MVAvatar vehicleUser, int seatID)
	{
	}

	public void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage)
	{
	}

	protected virtual HealthChangeAffects HealthChangeResult(float health)
	{
		return default;
	}

	public MVAvatar GetDriver()
	{
		return null;
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

	public bool IsPlayerInVehicle(int playerId)
	{
		return false;
	}
}
