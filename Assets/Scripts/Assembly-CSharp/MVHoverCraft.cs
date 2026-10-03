using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public class MVHoverCraft : MVSimpleOneSeatVehicle
{
	protected class LocalObjectsHoverCraft : LocalObjectsSimpleVehicle
	{
		public LocalObjectsHoverCraft(MVSimpleOneSeatVehicle vehicleBase, SmoothCharacterController smoothController, SimpleVehicleMotorBase hoverCraftMotor)
			: base(null, null, null)
		{
		}
	}

	public const float DefaultHealth = 150f;

	public const float MinHealth = 1f;

	public const float MaxHealth = 500f;

	public const float DefaultRandomLeaveVehicle = 0f;

	public const float MinRandomLeaveVehicle = 0f;

	public const float MaxRandomLeaveVehicle = 100f;

	private const float DeathExplosionDamageValue = 40f;

	private const float DeathExplosionRadius = 10f;

	private const float DeathExplosionImpulse = 2000f;

	private CullingSubscriberDynamic cullingSubscriberDynamic;

	private float randomLeaveVehicle;

	private HoverCraftVisualization HoverCraftVisualization => null;

	public override bool IsDead => false;

	public MVHoverCraft(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private HoverCraftVisualization.HoverCraftVisualizationSettings CreateHoverCraftVisualizationSettings()
	{
		return default;
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

	protected override HealthChangeAffects HealthChangeResult(float health)
	{
		return default;
	}

	protected override VehicleEnergyContainerConfig SetupVehicleEnergyContainerConfig()
	{
		return default;
	}

	public override void OnDataUpdate()
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
