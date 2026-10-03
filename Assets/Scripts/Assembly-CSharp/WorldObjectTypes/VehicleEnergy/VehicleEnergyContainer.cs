using System;
using System.Collections.Generic;
using UnityEngine;

namespace WorldObjectTypes.VehicleEnergy
{
	public class VehicleEnergyContainer : MonoBehaviour
	{
		private bool consumingEnergy;

		private float originalEnergyStorage;

		private float energyStorage;

		private float consumption;

		private readonly Dictionary<int, VehicleEnergyRefillPrediction> predictions;

		private int counter;

		public Action OnRefill;

		public bool UsingEnergy { get; private set; }

		public bool IsConsumingEnergy => false;

		public bool OutOfEnergy => false;

		public float EnergyStatus => 0f;

		public void Consume()
		{
		}

		public void Init(VehicleEnergyContainerConfig config)
		{
		}

		public void ConsumesEnergy(bool consuming)
		{
		}

		public void RefillEnergy(VehicleEnergyRefill vehicleEnergyRefill)
		{
		}

		private void ConfirmPrediction(VehicleEnergyRefill vehicleEnergyRefill)
		{
		}

		private void FixedUpdate()
		{
		}

		public void RollbackPrediction(int spawnerId)
		{
		}

		private void DoRollback(int key, VehicleEnergyRefill vehicleEnergyRefill)
		{
		}

		private void RollbackPrediction(VehicleEnergyRefill existingRefill)
		{
		}

		private void DoPrediction(VehicleEnergyRefill vehicleEnergyRefill)
		{
		}

		private void DoRefillEnergy(VehicleEnergyRefill vehicleEnergyRefill)
		{
		}
	}
}
