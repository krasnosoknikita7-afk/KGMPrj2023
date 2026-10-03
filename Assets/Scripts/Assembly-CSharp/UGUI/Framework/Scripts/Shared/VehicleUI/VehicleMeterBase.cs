using UnityEngine;

namespace UGUI.Framework.Scripts.Shared.VehicleUI
{
	public abstract class VehicleMeterBase : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		public RectTransform RectTransform => null;

		public abstract void Initialize(bool insideVehicle, MVRigidBody rigidBody);
	}
}
