using UnityEngine;

internal static class MVInputWrapper
{
	public class InputSuppression
	{
		private int suppressionFrame;

		protected virtual bool IsSuppressed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected InputSuppression(bool a)
		{
		}

		public static implicit operator InputSuppression(bool a)
		{
			return null;
		}

		public static implicit operator bool(InputSuppression a)
		{
			return false;
		}
	}

	private static float mouseSensitivtyModifier;

	private static InputSuppression isInputAllSuppressed;

	private static InputSuppression isShortcutKeysSuppressed;

	private static InputSuppression isInGameInputSuppressed;

	private static IKogamaInputMap inputMap;

	public static float MouseSensitivityModifier
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool IsAllInputSuppressed => false;

	public static bool IsShortcutKeysSuppressed => false;

	public static bool IsInGameInputSuppressed => false;

	public static void SuppressAllInput()
	{
	}

	public static void SuppressShortcutKeys()
	{
	}

	public static void SuppressInGameInput()
	{
	}

	public static void SetInputMap(IKogamaInputMap inputMap)
	{
	}

	public static bool GetBooleanControl(KogamaControls control)
	{
		return false;
	}

	public static bool GetBooleanControlDown(KogamaControls control)
	{
		return false;
	}

	public static bool GetBooleanControlUp(KogamaControls control)
	{
		return false;
	}

	private static bool GetBooleanControl(KogamaControls control, KeyState keyState)
	{
		return false;
	}

	public static Vector3 GetPointerPosition()
	{
		return default;
	}

	public static float GetAxis(string axis)
	{
		return 0f;
	}

	public static float GetAxisWithoutSensitivity(string axis)
	{
		return 0f;
	}

	public static float GetAxisRaw(string axis)
	{
		return 0f;
	}

	public static float GetAxisRawWithoutSensitivity(string axis)
	{
		return 0f;
	}

	public static void ResetInput()
	{
	}

	public static bool GetBooleanControlDeviceDependent(KogamaControls kogamaControls)
	{
		return false;
	}

	public static bool DebugGetKeyDown(KeyCode key)
	{
		return false;
	}

	public static bool DebugGetKeyDown(string st)
	{
		return false;
	}

	public static bool DebugGetKey(KeyCode key)
	{
		return false;
	}

	public static bool DebugGetKey(string st)
	{
		return false;
	}

	public static bool DebugGetKeyUp(KeyCode key)
	{
		return false;
	}

	public static bool DebugGetKeyUp(string st)
	{
		return false;
	}

	public static bool InputCharActive(KeyCode key)
	{
		return false;
	}

	public static bool InputCharActiveDown(KeyCode key)
	{
		return false;
	}

	public static string GetStringInput()
	{
		return null;
	}
}
