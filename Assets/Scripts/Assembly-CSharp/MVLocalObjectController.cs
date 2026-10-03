using System.Collections.Generic;
using MV.Common;

public class MVLocalObjectController : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase, IUpdatecontrollerSubscriberFixedUpdate
{
	private class AvatarLocalObjectPlaceHolder : ILocalObject
	{
		public int Id { get; private set; }

		public InputToInGameAction Update(InputToInGameAction movementMap)
		{
			return null;
		}

		public IInputToPlayerMovement FixedUpdate(IInputToPlayerMovement movementMap)
		{
			return null;
		}
	}

	internal interface IAttachInterface
	{
	}

	internal class DetachState : IAttachInterface
	{
	}

	internal class AttachState : IAttachInterface
	{
		private bool transformDataWasSuspended;

		private int woID;

		public AttachState(int worldObjectID)
		{
		}

		public void HandleAttachFailed()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	internal class DismountedPlayerControlledObject
	{
		private float dismountTime;

		private ILocalObject playerControlledObject;

		public ILocalObject PlayerControlledObject => null;

		public DismountedPlayerControlledObject(ILocalObject playerControlledObject)
		{
		}

		public bool ReadyToUnRegister()
		{
			return false;
		}

		public void SetTimeBeforeUnregister(float newTimeBeforeUnregister)
		{
		}
	}

	private const int MaxLocalControlledObjects = 4;

	private readonly IInputToPlayerMovement movementMap;

	private InputToInGameAction interactionInput;

	private IAttachInterface attachState;

	private readonly List<ILocalObject> localControlledStack;

	private readonly Dictionary<int, DismountedPlayerControlledObject> dismountedLocalControlledObjects;

	private readonly MVWorldObjectClientManagerNetwork worldObjectClientManagerNetwork;

	public const float TimeBeforeUnregister = 30f;

	public bool IsEnteringVehicle => false;

	public HashSet<int> LocalControlledWorldObjects => null;

	public MVWorldObjectClient CurrentWorldObject => null;

	public MVLocalObjectController(MVWorldObjectClientManagerNetwork worldObjectClientManagerNetwork)
	{
	}

	private static IInputToPlayerMovement CreateInputToPlayerMovement(MVGameMode gameMode)
	{
		return null;
	}

	public void SetAvatarLocalObject(ILocalObject localObject)
	{
	}

	public void RemoveAvatarLocalObject()
	{
	}

	public void Push(ILocalObject localObject)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public bool DetachWorldObjectFromVehicle(int worldObjectID, ref int vehicleID, bool leaveBecauseOfServer)
	{
		return false;
	}

	public void OverrideRemoveTimeForDismountedWorldObject(int woID, float timeBeforeUnregister)
	{
	}

	public void OnAttachWorldObjectToSeat(int instigatorActorNr, int seatOwnerWoID, int worldObjectID, int seatID)
	{
	}

	public bool AttachWorldObjectToSeat(int seatOwnerWoID, int worldObjectID, VehicleSeatBase seatBase)
	{
		return false;
	}

	public bool SpawnVehicleWithDriver(int worldObjectSpawnerVehicleID, int worldObjectID, VehicleSeatBase seatBase)
	{
		return false;
	}

	public bool VehicleEnergyUseRequest(int worldObjectSpawnerVehicleEnergyID, int worldObjectID)
	{
		return false;
	}

	public bool IsInsideVehicle(MVWorldObjectClient worldObjectClient = null)
	{
		return false;
	}

	public bool IsInsideVehicleUsingEnergy(MVWorldObjectClient worldObjectClient = null)
	{
		return false;
	}

	public void VehicleEnergyUseResponse(bool success, Dictionary<byte, object> returnValues)
	{
	}

	public void HandleDetachWorldObjectFromVehicle(bool success)
	{
	}

	public void HandleAttachWorldObjectToSeat(bool success)
	{
	}

	private void UpdateLocalControlledObjects()
	{
	}

	private void UpdateDismountedPlayerControlledObjects()
	{
	}

	private void FixedUpdateLocalControlledObjects()
	{
	}

	private void FixedUpdateDismountedPlayerControlledObjects()
	{
	}

	private bool HandleAttachFailed()
	{
		return false;
	}
}
