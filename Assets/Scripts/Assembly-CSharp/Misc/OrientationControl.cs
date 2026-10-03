using UnityEngine;

namespace Misc
{
	public class OrientationControl : MonoBehaviour
	{
		[SerializeField]
		private GameObject orientationWarningOverlay;

		[SerializeField]
		private bool printOrientation;

		[SerializeField]
		private bool toggleShowWarning;

		private bool takeAction;

		private MVOrientation desiredOrientation;

		private static bool debugging;

		public static MVOrientation CurrentOrientation => MVOrientation.Portrait;

		private static void PrintLog(string s)
		{
		}

		private static MVOrientation MapFromResolution(int width, int height)
		{
			return MVOrientation.Portrait;
		}

		private static MVOrientation MapFromDeviceOrientation(DeviceOrientation deviceOrientation)
		{
			return MVOrientation.Portrait;
		}

		private static MVOrientation MapFromScreenOrientation(ScreenOrientation screenOrientation)
		{
			return MVOrientation.Portrait;
		}

		private void Start()
		{
		}
	}
}
