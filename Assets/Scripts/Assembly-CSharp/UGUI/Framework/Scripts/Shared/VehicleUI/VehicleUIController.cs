using UnityEngine;

namespace UGUI.Framework.Scripts.Shared.VehicleUI
{
	public class VehicleUIController : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup vehicleUIGroup;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private SpeedOMeter speedOMeter;

		[SerializeField]
		private VehicleEnergyMeterText vehicleEnergyMeter;

		private static readonly Vector2 SizeOnlySpeed;

		private bool insideVehicle;

		private MVRigidBody rigidBody;

		private bool hasRigidBody;

		private Vector2 originalSize;

		private void Awake()
		{
		}

		private void OnSpawnRoleModeChange(int i)
		{
		}

		private void Start()
		{
		}

		private void UpdateRigidBody()
		{
		}

		private void OnIsInVehicleChange(bool value)
		{
		}

		private void OnSpeedOMeterShowHide(bool visible, float alpha)
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateVisibility()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
