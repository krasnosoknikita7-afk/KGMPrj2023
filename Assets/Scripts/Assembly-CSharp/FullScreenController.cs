using System;
using Misc;
using UnityEngine.Events;

public static class FullScreenController
{
	private static int screenWidthBeforeFullscreen;

	private static int screenHeightBeforeFullscreen;

	private static bool fullScreen;

	private static bool fullscreenStatCollected;

	public static bool fullscreenSupported;

	private static bool fakeFullscreen;

	private static bool initialized;

	private static bool debugging;

	public static UnityAction<bool> OnFullScreenChange;

	public static bool WaitingForFullscreenChange { get; private set; }

	public static bool FullScreen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ShouldHideOrientationWarning => false;

	private static void PrintLog(string s)
	{
	}

	public static void Init(int width, int height, bool init)
	{
	}

	public static void InitSupports(bool fsSupport, bool fake)
	{
	}

	private static void UpdateFullscreenIfApplicable()
	{
	}

	public static Tuple<int, int> GetWidthHeight(MVOrientation orientation, int widthInput, int heightInput)
	{
		return null;
	}

	public static void PrintMeasures(string prefix)
	{
	}

	public static void LateUpdate()
	{
	}

	public static bool AllowFullscreenChange()
	{
		return false;
	}

	private static bool IsFullscreenSupported()
	{
		return false;
	}
}
