using UnityEngine;

namespace WorldObjectTypes.VehicleEnergy
{
	public class MVVehicleEnergyObject : ObjectPrefab
	{
		[SerializeField]
		private VehicleEnergyVisuals vehicleEnergyVisuals;

		public VehicleEnergyVisuals VehicleEnergyVisuals => null;

		public GameObject VehicleEnergyVisualsGameObject => null;

		public void Taken()
		{
		}

		public void Spawned()
		{
		}
	}
}
