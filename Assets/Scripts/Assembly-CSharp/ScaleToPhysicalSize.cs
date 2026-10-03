using UnityEngine;

public class ScaleToPhysicalSize : MonoBehaviour
{
	[SerializeField]
	private RectTransform moveTarget;

	private static float dpiScale;

	private const float baseValueInches = 4.9f;

	private const int baseDPI = 96;

	private static bool debugging;

	public static float DpiScale => 0f;

	private static void PrintLog(string s)
	{
	}

	protected void Start()
	{
	}

	private static float GetScreenScaleValue()
	{
		return 0f;
	}
}
