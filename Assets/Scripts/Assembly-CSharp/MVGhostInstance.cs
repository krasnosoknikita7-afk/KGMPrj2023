using System.Collections.Generic;
using UnityEngine;

public class MVGhostInstance : MVWorldObjectClient, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase, IUpdatecontrollerSubscriberFixedUpdate, IGameStateControllerSubscriber
{
	private enum GameEffect
	{
		DAMAGE_OVER_TIME = 0,
		INSTANT_DEATH = 1
	}

	private enum GhostMode
	{
		MarkerActive = 0,
		InstanceActive = 1
	}

	private SphereVolumeIndicator rangeVis;

	private float distance;

	private float speed;

	private Transform moveTarget;

	private Vector3 oscilPos;

	private float oscillationPeriod;

	private float damagePerSecond;

	private float turnSlerpFactor;

	private GameEffect gameEffect;

	private float patrolSpeed;

	private SmoothPhysicsMovement smoothPhysicsMovement;

	private GameObject _ghostInstance;

	private GameObject _ghostMarker;

	private Bounds localBounds;

	private CullingSubscriberBase cullingSubscriberBase;

	private bool isLODVisible;

	private GhostMode ghostMode;

	private Vector3 lodSphereOffset;

	private int playerLayer;

	private List<MVWorldObjectClient> targetWos;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public float Distance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public MVGhostInstance(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	private void SetupCulling()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void UpdateMarkerPosition(Vector3 newPos)
	{
	}

	private void OnStateChange(CullingGroupEvent cullingGroupEvent)
	{
	}

	public override void InitializeInventory()
	{
	}

	public void InitializeCommon()
	{
	}

	private static Bounds ComputeLocalBounds(Vector3 origin, MeshRenderer[] meshRenderers)
	{
		return default;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Select()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	private void ReadWOData()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public void GameStateChanged(UpdateCondition condition)
	{
	}

	private void UpGhosts()
	{
	}

	public override void Destroy()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	private void MoveGhost(MVWorldObjectClient TargetAvatar)
	{
	}

	private Vector3 GetTargetPos(bool patrolling)
	{
		return default;
	}

	private void ApplyGameEffect(MVWorldObjectClient targetAvatar, InteractionDataHandlerBase interactionHandler)
	{
	}

	private bool IsTouchingAvatar(MVWorldObjectClient TargetAvatar)
	{
		return false;
	}

	private void UpdateVisualEffects(bool touchingAvatar)
	{
	}

	private Vector3 GetTacticalPos()
	{
		return default;
	}

	private float GetSpeed(bool patrolling)
	{
		return 0f;
	}
}
