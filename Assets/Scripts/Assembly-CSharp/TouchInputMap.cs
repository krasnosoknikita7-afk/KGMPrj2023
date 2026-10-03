using System.Collections.Generic;
using UnityEngine;

public class TouchInputMap : IKogamaInputMap
{
	private Dictionary<KogamaControls, string[]> ButtonMapping;

	private Dictionary<KogamaControls, KeyCode> KeyCodeMapping;

	public bool GetBooleanControl(KogamaControls control, KeyState keyState)
	{
		return false;
	}
}
