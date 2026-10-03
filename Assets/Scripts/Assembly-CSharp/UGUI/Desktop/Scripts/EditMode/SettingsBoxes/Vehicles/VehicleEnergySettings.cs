using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using WorldObjectTypes.VehicleEnergy;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles
{
	public class VehicleEnergySettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		public static class DataKeys
		{
			public const string Name = "VehicleEnergyName";

			public const string SpawnOption = "RespawnCount";

			public const string SpawnTime = "RespawnInterval";

			public const string EnergyAmount = "VehicleEnergyAmount";
		}

		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsInputField nameInputField;

		[SerializeField]
		private SettingsSlider spawnOptionsSlider;

		[SerializeField]
		private SettingsInputFieldSlider spawnOptionsInputSlider;

		[SerializeField]
		private SettingsSlider spawnTimeSlider;

		[SerializeField]
		private SettingsInputFieldSlider spawnTimeInputSlider;

		[SerializeField]
		private SettingsSlider energyAmountSlider;

		[SerializeField]
		private SettingsInputFieldSlider energyAmountInputSlider;

		private Dictionary<object, object> vehicleEnergyBpData;

		private Dictionary<object, object> spawnerBpData;

		private int vehicleEnergyWoID;

		private MVWorldObjectSpawnerVehicleEnergy vehicleEnergySpawner;

		private MVVehicleEnergy vehicleEnergySpawnObject;

		public void Initialize(int woID, GameObject root)
		{
		}

		private void InitVehicleEnergyBpData()
		{
		}

		private void InitSpawnerBpData()
		{
		}

		public void OnSettingChanged(string key, object value)
		{
		}

		private void UpdateSpawnOptionText(int newSpawnOption)
		{
		}
	}
}
