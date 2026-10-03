using UnityEngine;

public class HamsterWheelVisualization : VehicleVisualizationBase
{
	public enum SpeedState
	{
		Idle = 0,
		Moving = 1
	}

	public GameObject wheel;

	[SerializeField]
	private VehicleBlinker vehicleBlinker;

	[SerializeField]
	private Transform hamsterWheelVisualizationRoot;

	private VehicleSeatManager vehicleSeatManager;

	public AvatarBlobShadowController blobShadow;

	private float curHealth;

	private Vector3 prevPosition;

	private Vector3 velocity;

	private SpeedState speedState;

	public AudioSource audioSourceRolling;

	public AudioSource audioSourceWind;

	private bool vehicleIsUnoccupied;

	private float unoccupiedTime;

	private float vehicleAboutToBeRemovedTime;

	private void Awake()
	{
	}

	public void Init(VehicleSeatManager vehicleSeatManager, float fullHealth, MVRuntimeDataVariableClampedFloat health, MVRuntimeDataVariable isMovingForward, MVRuntimeDataVariable isMovingBackwards, MVRuntimeDataVariable isGrounded, bool isInSpawner)
	{
	}

	public void OnSeatOccupiedChange()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHealthChange(float newHealth)
	{
	}

	private void OnGroundedChange(bool val)
	{
	}

	private void HandleUnoccupiedVehicle()
	{
	}
}
