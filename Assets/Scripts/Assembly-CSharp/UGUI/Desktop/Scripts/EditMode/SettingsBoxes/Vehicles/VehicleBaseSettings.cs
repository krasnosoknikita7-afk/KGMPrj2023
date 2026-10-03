using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles
{
	public abstract class VehicleBaseSettings : MonoBehaviour
	{
		[SerializeField]
		protected SettingsBase settingsBase;

		[SerializeField]
		private RectTransform canvas;

		[FormerlySerializedAs("vehicleEnergySettings")]
		[SerializeField]
		protected VehicleEnergyForVehicleSettings vehicleEnergyForVehicleSettings;

		public Action OnInitialized;

		protected MVWorldObjectSpawnerVehicle spawnerVehicle;

		protected MVVehicleBase vehicleBase;

		protected int vehicleWoID;

		protected Dictionary<object, object> bluePrintData;

		protected virtual Vector2 DefaultCanvasSize => default;

		public static string SettingsKey(string key)
		{
			return null;
		}

		public object GetBluePrintData(object key)
		{
			return null;
		}

		public void Initialize(int woID, GameObject root)
		{
		}

		public abstract void Initialize(GameObject root);

		public abstract Dictionary<object, object> FillDefaultBlueprintData();

		public abstract void BlueprintDataRetrieved();

		public abstract VehicleEnergyForVehicleSettingsConfig GetVehicleEnergySettingsConfig();

		public void OnVehicleEnergySettingsOpen()
		{
		}

		public void SetCanvasSize(Vector2 size)
		{
		}

		public void ResetCanvasSize()
		{
		}
	}
}
