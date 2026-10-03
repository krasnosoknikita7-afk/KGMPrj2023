using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles
{
	public class VehicleEnergyForVehicleSettings : MonoBehaviour
	{
		public static readonly Vector2 VehicleEnergyEditingCanvasSize;

		public const string VehicleEnergyOn = "vehicleEnergyUse";

		public const string VehicleEnergyStorage = "vehicleEnergyStorage";

		public const string VehicleEnergyConsumption = "vehicleEnergyConsumption";

		[SerializeField]
		private VehicleBaseSettings vehicleBaseSettings;

		[SerializeField]
		private SettingsToggle vehicleEnergyOnToggle;

		[SerializeField]
		private SettingsSlider storageSlider;

		[SerializeField]
		private SettingsInputFieldSlider storageInputField;

		[SerializeField]
		private SettingsSlider consumptionSlider;

		[SerializeField]
		private SettingsInputFieldSlider consumptionInputField;

		private void Start()
		{
		}

		public void OnSavePressed()
		{
		}

		public static bool IsKey(string key)
		{
			return false;
		}

		public object ValueToSend(string key, object value)
		{
			return null;
		}
	}
}
