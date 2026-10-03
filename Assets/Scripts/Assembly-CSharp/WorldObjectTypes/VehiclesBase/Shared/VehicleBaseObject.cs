using UnityEngine;

namespace WorldObjectTypes.VehiclesBase.Shared
{
	public class VehicleBaseObject : ObjectPrefab
	{
		[SerializeField]
		private AudioSource vehicleEnergyPickupSound;

		[SerializeField]
		protected BulletImpactVisualizer bulletImpactVisualizer;

		public IBulletImpactVisualizer BulletImpactVisualizer => null;

		public AudioSource VehicleEnergyPickupSound => null;
	}
}
