using UnityEngine;
using UnityEngine.UI;
using WorldObjectTypes.VehicleEnergy;

namespace UGUI.Framework.Scripts.Shared.VehicleUI
{
	public class VehicleEnergyMeterText : VehicleMeterBase
	{
		[SerializeField]
		private CanvasGroup vehicleEnergyMeterTextGroup;

		[SerializeField]
		private Text energyText;

		private bool updateEnergy;

		private VehicleEnergyContainer vehicleEnergyContainer;

		private int currentEnergyStatus;

		private const int BlinkingLimit = 19;

		private const int BlinkHeight = 4;

		private int lastBlink;

		private Color originalColor;

		private Vector3 originalTextPos;

		private static readonly Color WarningColor;

		public bool IsVisible => false;

		private void Awake()
		{
		}

		public override void Initialize(bool insideVehicle, MVRigidBody rigidBody)
		{
		}

		public void UpdateEnergy()
		{
		}

		private void OnRefillCallback()
		{
		}

		private void VisualStuff()
		{
		}
	}
}
