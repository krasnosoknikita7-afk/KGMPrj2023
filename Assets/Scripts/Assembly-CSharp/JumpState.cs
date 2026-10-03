using System.Collections.Generic;
using UnityEngine;

internal class JumpState
{
	private enum JumpType
	{
		Regular = 0,
		Wall = 1,
		Water = 2
	}

	public delegate void OnWallJumpDelegate();

	private readonly float extraHeight;

	private const float baseHeight = 1f;

	private float jumpHeight;

	private readonly float sliperyValMin;

	private readonly float sliperyValMax;

	private readonly float regularButtonDownTimeLimit;

	private readonly float bouncyMaterialButtonDownTimeLimit;

	private readonly float bouncinessThresshold;

	private readonly float wallJumpAngleMin;

	private readonly float wallJumpAngleMax;

	private readonly float jumpTimeOutWallJump;

	private readonly bool canWallJumpAnySurface;

	private readonly int airJumpsAllowed;

	private float jumpVelocityMultiplier;

	private int airJumpsDone;

	private bool holdingJumpButton;

	private float lastStartTime;

	private float lastButtonDownTime;

	private float jumpTimeOut;

	private Vector3 jumpDir;

	private float accExtraHeight;

	private Vector3 latestSlopeDir;

	private bool jumping;

	private bool airJumping;

	public OnWallJumpDelegate OnWallJump;

	private List<MVControllerColliderHit> wallJumpHits;

	public bool Jumping => false;

	public bool AirJumping => false;

	public JumpState(float regularButtonDownTimeLimit, WorldObjectSkillDataManager skillDataManager)
	{
	}

	public JumpState(float regularButtonDownTimeLimit)
	{
	}

	public void Destroy()
	{
	}

	public void UpdateJumpState(GroundChange groundChange)
	{
	}

	public Vector3 ApplyJumping(MVInteractableBase interactableLocal, MVGroundState groundState, float density, float waterProximity, bool inputJump, Vector3 velocity, Vector3 movableVelocity)
	{
		return default;
	}

	private void SetJumpState(bool wallJumpPossible, float sliperyFactor)
	{
	}

	private float GetSliperyFactor(MVInteractableBase interactableLocal, MVGroundState groundState, float waterProximity, bool canWaterJump, bool isDoingAirJump)
	{
		return 0f;
	}

	private float GetJumpSpeed(MVInteractableBase interactableLocal, float sliperyFactor, bool isDoingAirJump)
	{
		return 0f;
	}

	private Vector3 GetJumpTypeVelocity(Vector3 velocity, JumpType jumpType)
	{
		return default;
	}

	private Vector3 GetWallJumpVelocity(Vector3 velocity)
	{
		return default;
	}

	private Vector3 JumpDir(ref JumpType jumpType, MVGroundState groundState, float sliperyFactor, bool wallJumpPossible, bool canWaterJump)
	{
		return default;
	}

	private void UpdateWallJumpValues()
	{
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}

	private float SpreadFunction(float x)
	{
		return 0f;
	}

	private bool CanAirJump()
	{
		return false;
	}

	private void HandleJumpBoost()
	{
	}
}
