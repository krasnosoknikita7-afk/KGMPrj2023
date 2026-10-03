using System.Collections.Generic;
using UnityEngine;

public class JoystickControllerStack : MonoBehaviour
{
	private List<InGameControls> controls;

	[SerializeField]
	private InGameControls avatar;

	[SerializeField]
	private InGameControls basicVehicle;

	[SerializeField]
	private InGameControls jetPackControls;

	private void Awake()
	{
	}

	public void ShowEUseIcon(ShowUseOption option)
	{
	}

	public void HideEUseIcon()
	{
	}

	public void PushJoystick(ControlType joystickType)
	{
	}

	public void Pop()
	{
	}

	private void CreateJoystickFromPrefab(InGameControls prefab)
	{
	}
}
