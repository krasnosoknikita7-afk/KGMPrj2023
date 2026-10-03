using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class AvatarInteractable : MVInteractable, IMoveHitHandler
{
	public class DamageSource
	{
		public static readonly DamageSource none;

		public MVPlayer shooter;

		public PlayerKilledByType damageType;

		public float time;

		private const float lifeTime = 4f;

		public bool Outdated => false;

		public DamageSource(MVPlayer shooter, PlayerKilledByType damageType)
		{
		}

		private DamageSource()
		{
		}
	}

	public Action<float, MVPlayer, PlayerKilledByType> OnDamageTaken;

	public Action<Vector3> OnNewSafePosition;

	public Action OnShieldReplenished;

	private DamageSource lastDamageSource;

	private float boostedHealthMultiplier;

	private float damageMultiplier;

	private HashSet<PlayerKilledByType> KillNotificationBlacklist;

	private readonly MaterialHitPackage[] hitPackages;

	private InteractableMaterialHitHandler materialHitHandler;

	private bool canWallJumpAnySurfaces;

	private static readonly int AvatarModifierPackagesCount;

	public DamageSource LastDamageSource => null;

	public override void Init(MVRuntimeDataVariable runtimeDataModifiers, MVRuntimeDataVariable<float> health, MVRuntimeDataVariable<int> maxHealth, MVRuntimeDataVariableClampedFloat shield, WorldObjectSkillDataManager skillDataManager)
	{
	}

	private void OnDestroy()
	{
	}

	public void InitializeSkills(WorldObjectSkillDataManager skillDataManager)
	{
	}

	public override void TakeDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void TakeDamageOverTime(AvatarModifierPackageType type, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	private void DoKilledNotification(MVPlayer damageDealer, PlayerKilledByType defaultDamageType)
	{
	}

	private float GetBoostedHealth(float defaultHealth)
	{
		return 0f;
	}

	public void DieFromRespawn(MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public void DieFromStuck()
	{
	}

	public void DieFromFalling()
	{
	}

	public void DieFromBeingStuck()
	{
	}

	protected override void RestoreShield(float restoredShieldAmount)
	{
	}

	private float DamageShield(float amount)
	{
		return 0f;
	}

	public override void AddModifier(AvatarModifierPackageType type, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}

	private bool IsGroundedSafely(MVControllerColliderHit moveHit)
	{
		return false;
	}

	private void SetupBoostedHealthMultiplier()
	{
	}

	private void HandlePoisonResistBoost()
	{
	}
}
