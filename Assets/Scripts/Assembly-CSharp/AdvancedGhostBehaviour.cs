using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostBehaviour : MonoBehaviour
{
	private interface IGhostBehaviourState
	{
		void Enter(AdvancedGhostBehaviour ghostBehaviour);

		Type Update(AdvancedGhostBehaviour ghostBehaviour);

		void Exit(AdvancedGhostBehaviour ghostBehaviour);
	}

	private abstract class GhostBehaviourState : IGhostBehaviourState
	{
		public abstract void Enter(AdvancedGhostBehaviour ghostBehaviour);

		public Type Update(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		protected abstract Type UpdateState(AdvancedGhostBehaviour ghostBehaviour);

		public abstract void Exit(AdvancedGhostBehaviour ghostBehaviour);
	}

	private class Idle : GhostBehaviourState
	{
		private float idleRotationSpeed;

		public override void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		protected override Type UpdateState(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public override void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class Die : IGhostBehaviourState
	{
		private float dieTime;

		private float currentDieTime;

		private float deathRotationSpeed;

		public void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		public Type Update(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class Dead : IGhostBehaviourState
	{
		public void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		public Type Update(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class ResetState : IGhostBehaviourState
	{
		public void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		public Type Update(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class Alert : GhostBehaviourState
	{
		private float alertRotationSpeed;

		private float alertMultiplier;

		public override void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		protected override Type UpdateState(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public override void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class Attack : GhostBehaviourState
	{
		private float attackRotationSpeed;

		public override void Enter(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		protected override Type UpdateState(AdvancedGhostBehaviour ghostBehaviour)
		{
			return null;
		}

		public override void Exit(AdvancedGhostBehaviour ghostBehaviour)
		{
		}
	}

	private class AdvancedGhostPerception
	{
		public MVTeam alliedTeam;

		private AdvancedGhostBehaviour ghostBehaviour;

		private OptimizedPerception perception;

		private int currentWoID;

		private int perceptionIntervalMilliseconds;

		private DeterministicSyncedInterval syncedInterval;

		public MVTeam AlliedTeam
		{
			get
			{
				return MVTeam.Blue;
			}
			set
			{
			}
		}

		public AdvancedGhostPerception(AdvancedGhostBehaviour ghostBehaviour, int woID)
		{
		}

		public void Reset()
		{
		}

		public void Update()
		{
		}

		public bool TryGetCurrentTarget(out MVWorldObjectClient worldObjectClient)
		{
			worldObjectClient = null;
			return false;
		}

		public bool TryGetNewTarget(out MVWorldObjectClient worldObjectClient)
		{
			worldObjectClient = null;
			return false;
		}

		private bool TryGetTarget(List<WorldObjectClientRef> targets, out MVWorldObjectClient target)
		{
			target = null;
			return false;
		}

		private bool CanSense(Vector3 targetPosition)
		{
			return false;
		}

		private bool IsWithinRoamRadius(Vector3 targetPosition)
		{
			return false;
		}

		private bool IsWithinPerceptionRadius(Vector3 targetPosition)
		{
			return false;
		}

		private float DistanceToTargetPosition(Vector3 targetPosition)
		{
			return 0f;
		}
	}

	private class NetworkedValues
	{
		private const float pi2 = (float)Math.PI * 2f;

		private Vector3 lookDir;

		private float minLookDeltaOffset;

		private const float idleTargetPosMoveSpeedFactor = 0.2f;

		private AdvancedGhostBehaviour ghostBehaviour;

		private Vector3 nextPosition;

		private Func<int, float, float, Transform, Vector3> patrolPattern;

		private int prevServertime;

		private bool didMeasure;

		public Vector3 SyncPosition => default;

		public Vector3 SyncLookDir => default;

		public NetworkedValues(AdvancedGhostBehaviour ghostBehaviour)
		{
		}

		public void Update()
		{
		}

		public Vector3 GetPosition(float delta)
		{
			return default;
		}

		private void GetNextLookAt(Vector3 curPosition, int serverTimeInMilliSeconds)
		{
		}

		private void Test(double serverTimeNormalizedToPeriod)
		{
		}

		private Vector3 EaseInEaseOutBackAndForward(int serverTimeInMilliSeconds, float speed, float radius, Transform transform)
		{
			return default;
		}

		private Vector3 Circle(int serverTimeInMilliSeconds, float speed, float radius, Transform transform)
		{
			return default;
		}

		private float GetX(float serverTimeWithSpeedFactor, float radius)
		{
			return 0f;
		}

		private float GetY(float serverTimeWithSpeedFactor, float radius)
		{
			return 0f;
		}

		private Vector3 BackAndForward(int serverTimeInMilliSeconds, float speed, float radius, Transform transform)
		{
			return default;
		}
	}

	private const float advancedGhostBodyMaxRadius = 4f;

	private CullingSubscriberBase cullingSubscriberBase;

	private const int behaviourOnlyDistanceBand = 3;

	private bool behaviourOnlyEnabled;

	private bool allVisible;

	private bool wantsVisible;

	private IGhostBehaviourState currentState;

	private AdvancedGhostMotor advancedGhostMotor;

	private NetworkedValues networkedValues;

	private AdvancedGhostPerception perception;

	private Transform transformParent;

	private Vector3 nextPosition;

	private int lives;

	private int maxLives;

	private Func<bool> deathCheckFunc;

	private ObscuredFloat speed;

	private float radius;

	private float perceptionRadius;

	private float minPerceptionRadius;

	private float speedPerceptionFactor;

	private bool respawn;

	private bool clearEffectsBecauseOfReset;

	private AdvancedGhostBodyRotateWeapon weapon;

	public AdvancedGhostVisualizaton GhostVisualization;

	public int Lives
	{
		set
		{
		}
	}

	private bool IsDead => false;

	private float RoamRadius => 0f;

	public float Speed
	{
		set
		{
		}
	}

	public float Radius
	{
		set
		{
		}
	}

	public MVTeam Team
	{
		get
		{
			return MVTeam.Blue;
		}
		set
		{
		}
	}

	public CullingSubscriberBase CullingSubscriberBase => null;

	private void Awake()
	{
	}

	public void Init(MVCubeModelBase body, AdvancedGhostMotor advancedGhostMotor, Func<bool> deathCheckFunc, int woID)
	{
	}

	public void EditModeUpdateCulling()
	{
	}

	private void SetupCulling()
	{
	}

	private void OnStateChange(CullingGroupEvent cullingGroupEvent)
	{
	}

	private void OnDestroy()
	{
	}

	private void InitBody(MVCubeModelBase body)
	{
	}

	private void SetVisible()
	{
	}

	public void SetGameMode(bool isPlayMode)
	{
	}

	public void Reset()
	{
	}

	public void ReceivedDamage()
	{
	}

	public void ReceivedHealing()
	{
	}

	protected void Update()
	{
	}

	protected void FixedUpdate()
	{
	}

	private void DoRespawn()
	{
	}

	private void SetInitialState()
	{
	}

	private void UpdatePositionAndRotation()
	{
	}

	private void UpdateBehaviourState()
	{
	}

	private void SetCurrentState(Type type)
	{
	}

	private Vector3 GetMoveVector(Vector3 targetPos)
	{
		return default;
	}

	private void SetDesiredPosition(Vector3 position)
	{
	}
}
