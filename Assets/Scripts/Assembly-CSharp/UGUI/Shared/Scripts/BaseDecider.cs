using UnityEngine;

namespace UGUI.Shared.Scripts
{
	public class BaseDecider : MonoBehaviour
	{
		[SerializeField]
		private GameObject touchDetectionHandlerPrefab;

		[SerializeField]
		private Canvas canvas;

		private static void Log(string msg)
		{
		}

		private void Awake()
		{
		}

		public void StartButtonPressed(bool mobile)
		{
		}
	}
}
