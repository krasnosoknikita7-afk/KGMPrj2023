using System.Collections.Generic;
using UnityEngine;

public class VehicleSeatManager : MonoBehaviour
{
	public delegate void OnSeatOccupiedChangeDelegate();

	public OnSeatOccupiedChangeDelegate OnSeatOccupiedChange;

	public List<VehicleSeatBase> seats;

	public TriggerBoxEvents triggerBoxEvents;

	private UseInteractor useInteractor;

	private MVVehicleBase woOwner;

	private int occupiedSeatCount;

	private bool isDead;

	private bool enterVehicleDisabled;

	public int OccupiedSeatsCount => 0;

	public VehicleSeatBase DriverSeat => null;

	public bool EnterVehicleDisabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnIsDeadChange(object isDeadRuntime)
	{
	}

	public void Init(MVVehicleBase wo, MVRuntimeDataVariable isDeadRuntimeVariable)
	{
	}

	private bool CheckCanUse(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	public bool Use(int userWoId)
	{
		return false;
	}

	public void AttachWorldObjectToSeat(int instigatorActorNr, bool instigatorIsLocal, MVAvatar vehicleUser, int vehicleSeatID)
	{
	}

	private void SetToSeatTransform(MVAvatar vehicleUser, int seatID)
	{
	}

	private void UpdateTriggerBoxEventsCollider()
	{
	}

	public void DetachFromSeat(MVAvatar vehicleUser)
	{
	}
}
