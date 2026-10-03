using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopDefaultKeyboardMapping : IKogamaInputMap
{
	protected class ControlBitArray
	{
		private BitArray controlDown;

		public bool this[KogamaControls ctrl]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Reset()
		{
		}
	}

	protected Dictionary<KogamaControls, KeyCode[]> keyMapping;

	protected ControlBitArray controlDown;

	public void Reset()
	{
	}

	public bool GetBooleanControl(KogamaControls control, KeyState keyState)
	{
		return false;
	}

	private bool KeyDown(KogamaControls control)
	{
		return false;
	}

	private bool KeyUp(KogamaControls control)
	{
		return false;
	}
}
