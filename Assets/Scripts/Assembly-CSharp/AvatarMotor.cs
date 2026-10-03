using UnityEngine;

public class AvatarMotor : MVRigidBody
{
	public delegate void OnWallJumpDelegate();

	public delegate void OnActiveBounceDelegate();

	public const float WalkSpeedDefaultBase = 8f;

	private const float AirAccelerationDefault = 3f;

	private float walkSpeed;

	private float walkSpeedBase;

	private float speed;

	private AnimationCurve slopeSpeedMultiplier;

	private Vector3 velocityPrevFrame;

	private JumpState jumpState;

	private BounceState bounceState;

	private WaterState waterState;

	private SmoothCharacterController smoothCharacterController;

	private ImpactState impactState;

	private MVMovableMotorState movableMotorState;

	private AvatarInteractable interactableLocal;

	private float speedBoostSetting;

	private float slowFallVelocityMultiplier;

	private float frictionMultiplier;

	protected StuckEvaluator stuckEvaluator;

	public OnWallJumpDelegate OnWallJump;

	public OnActiveBounceDelegate OnActiveBounce;

	private float currentLerp;

	private readonly float lerpTime;

	private MvCharacterController Controller => null;

	public SizeState GetSizeState { get; private set; }

	public float WalkSpeedBase
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float FrictionCoefficient => 0f;

	public override Vector3 Velocity => default;

	public override bool Grounded => false;

	public override bool IsMovementLocked { get; set; }

	protected override void SuspendImpactDamage()
	{
	}

	public bool IsStuck()
	{
		return false;
	}

	public void Init(AvatarInteractable interactableLocal, Vector3 centerOffset, MVWorldObjectClient worldObjectOwner, WorldObjectSkillDataManager skillDataManager)
	{
	}

	private void InitSkills(WorldObjectSkillDataManager skillDataManager)
	{
	}

	public void OverrideCharacterController(SmoothCharacterController controller)
	{
	}

	public override void Reset()
	{
	}

	public void UpdateFunction()
	{
	}

	public void FixedUpdateFunction(IMotorAPI motorApi)
	{
	}

	public void UpdateVelocity()
	{
	}

	private void HandleSoundEffects(bool inputJump)
	{
	}

	private void HandleMovementBoost()
	{
	}

	private void OnDestroy()
	{
	}

	private Vector3 GetVelocity(Vector3 velocity, Vector3 movableVelocity, bool inputJump, Vector3 inputDirection)
	{
		return default;
	}

	protected void DealImpactDamage(Vector3 curVelocity, Vector3 prevVelocity)
	{
	}

	private void Move(Vector3 velocity, Vector3 movableVelocity)
	{
	}

	private Vector3 ApplyInputVelocityChangeGrounded(Vector3 velocity, Vector3 inputDirection)
	{
		return default;
	}

	private Vector3 ApplyInputVelocityChange(Vector3 velocity, Vector3 inputDirection)
	{
		return default;
	}

	private float GetSpeedGrounded(float currentSpeed, Vector3 inputDirection)
	{
		return 0f;
	}

	private float GetSpeed(float currentSpeed, Vector3 inputDirection)
	{
		return 0f;
	}

	public bool IsJumping()
	{
		return false;
	}

	public bool IsAirJumping()
	{
		return false;
	}
}
