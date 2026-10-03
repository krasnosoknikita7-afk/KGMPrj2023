using System.Collections.Generic;
using UnityEngine;

namespace WorldObjectTypes.VehicleEnergy
{
	public class MVWorldObjectSpawnerVehicleEnergy : MVWorldObjectSpawner
	{
		private CullingSubscriberBase cullingSubscriberBase;

		private GameObject lodGameObject;

		private GameObject visualsGameObject;

		private bool initFlag;

		private GreyOutObjectScript pickupItemObjectScript;

		private readonly SpawnerObject spawnerObject;

		private MVVehicleEnergy vehicleEnergyChild;

		public int SpawnWorldObjectID => 0;

		public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
		{
			return default;
		}

		public MVWorldObjectSpawnerVehicleEnergy(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void OnDataUpdate()
		{
		}

		public override void Destroy()
		{
		}

		public override void Initialize()
		{
		}

		private void SetupCulling()
		{
		}

		private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
		{
		}

		private void OnStateChanged(CullingGroupEvent cullingGroupEvent)
		{
		}

		public override void InitializeInventory()
		{
		}

		private void InitializeCommon()
		{
		}

		public override void SetupTierInventory()
		{
		}

		protected override void OnSpawnStateChange(SpawnState spawnState)
		{
		}

		public override void Select(Color color)
		{
		}

		protected override bool CheckCanUse(int woId, MVInteractableBase avatarInteractable)
		{
			return false;
		}

		protected override bool Use(int userWoID)
		{
			return false;
		}

		private void OnEnterTriggerBox(object sender, TriggerEventArgs e)
		{
		}

		public VehicleEnergyRefill CreateVehicleEnergyRefill(bool prediction)
		{
			return default;
		}

		public override bool OnEnterObject(EditorStateMachine e)
		{
			return false;
		}

		public override bool OnExitObject(EditorStateMachine e)
		{
			return false;
		}

		public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
		{
			return false;
		}
	}
}
