using System.Collections.Generic;
using UnityEngine;

namespace WorldObjectTypes.VehicleEnergy
{
	public class MVVehicleEnergy : MVBlueprintBase
	{
		public struct VehicleEnergyConfiguration
		{
			public string name;

			public int spawnOption;

			public int spawnTime;

			public int energyAmount;
		}

		public const string DefaultName = "Vehicle Energy";

		public const int DefaultSpawnOption = 10;

		public const int MinSpawnOption = 1;

		public const int MaxSpawnOption = 10;

		public const int DefaultSpawnTime = 15;

		public const int MinSpawnTime = 5;

		public const int MaxSpawnTime = 240;

		public const int DefaultEnergyAmount = 30;

		public const int MinEnergyAmount = 5;

		public const int MaxEnergyAmount = 100;

		private EditableCubeModelWrapper editableCubeModelWrapper;

		private MVVehicleEnergyObject vehicleEnergyObject;

		public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

		public MVCubeModelInstance CubeModelInstance => null;

		public GameObject VehicleEnergyVisualsGameObject { get; private set; }

		public VehicleEnergyConfiguration VehicleEnergyConfig { get; private set; }

		public MVVehicleEnergy(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void Initialize()
		{
		}

		private void UpdateVehicleEnergyConfig()
		{
		}

		public override void OnDataUpdate()
		{
		}

		private VehicleEnergyConfiguration ReadWorldObjectData()
		{
			return default;
		}

		private static VehicleEnergyConfiguration CreateDefaultVehicleEnergyConfig()
		{
			return default;
		}

		public void Taken()
		{
		}

		public void Spawned()
		{
		}

		private void ToggleColliders(bool val)
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
	}
}
