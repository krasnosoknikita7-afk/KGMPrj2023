using UnityEngine;

namespace WorldObjectTypes.VehicleEnergy
{
	public class VehicleEnergyVisuals : MonoBehaviour
	{
		[SerializeField]
		private Transform vehicleEnergyRoot;

		[SerializeField]
		private MVVehicleEnergyObject vehicleEnergyObject;

		[SerializeField]
		private bool particleSystemOn;

		[SerializeField]
		private ParticleSystem particles;

		private RotateLocal rotateLocal;

		private void Awake()
		{
		}

		public void ToggleVisuals(bool val)
		{
		}

		public void Rotate(bool onOff)
		{
		}
	}
}
