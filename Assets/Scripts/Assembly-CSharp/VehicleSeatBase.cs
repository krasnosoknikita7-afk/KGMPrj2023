using MV.Common;
using UnityEngine;

public class VehicleSeatBase : MonoBehaviour
{
	private int seatID;

	private MVAvatar owner;

	private MVCameraBase seatCamera;

	[SerializeField]
	private MVCameraBase AndroidCamera;

	[SerializeField]
	private MVCameraBase DesktopCamera;

	public Transform AvatarAttachPoint;

	public SeatType SeatType;

	public bool UnequipVehicleUser;

	[SerializeField]
	private ControlType joystickType;

	public bool IsOccupied { get; set; }

	public MVAvatar Owner => null;

	public MVCameraBase Camera => null;

	public int SeatID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void SetCamera()
	{
	}

	public virtual void RemoveCamera()
	{
	}

	public virtual void Attach(MVAvatar avatar)
	{
	}

	public virtual void Detach(MVAvatar avatar)
	{
	}

	public void PushJoystick()
	{
	}

	public void PopJoystick()
	{
	}
}
