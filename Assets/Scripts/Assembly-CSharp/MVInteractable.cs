public abstract class MVInteractable : MVInteractableBase
{
	protected AvatarModifierPackages modifierPackages;

	protected MVRuntimeDataVariable runtimeDataModifiers;

	protected MVRuntimeDataVariable<float> health;

	protected MVRuntimeDataVariable<int> maxHealth;

	protected MVRuntimeDataVariableClampedFloat shield;

	protected float poisonResist;

	private float healthRegenerationPerSecondSetting;

	private float shieldRegenerationPerSecondSetting;

	public AvatarModifierPackages ModifierPackages => null;

	public virtual void Init(MVRuntimeDataVariable runtimeDataModifiers, MVRuntimeDataVariable<float> health, MVRuntimeDataVariable<int> maxHealth, MVRuntimeDataVariableClampedFloat shield, WorldObjectSkillDataManager skillDataManager)
	{
	}

	public virtual void InitializeSetings(float healthRegenerationPerSecondSetting, float shieldRegenerationPerSecondSetting)
	{
	}

	protected virtual void RestoreShield(float restoredShieldAmount)
	{
	}

	protected bool IgnoreDamage(MVPlayer damageDealer)
	{
		return false;
	}

	protected bool IgnoreHealing(MVPlayer damageDealer)
	{
		return false;
	}

	private void Update()
	{
	}

	public override void AddModifier(AvatarModifierPackageType type, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public override bool HasModifier(AvatarModifierPackageType type)
	{
		return false;
	}

	public override void RemoveModifier(AvatarModifierPackageType type, int id = -1)
	{
	}

	public override void ClearModifiers()
	{
	}

	public override bool HasModifierEffect(AvatarModifierEffect avatarModifierEffect)
	{
		return false;
	}

	public override float HandleModifierEffect(AvatarModifierEffect avatarModifierEffect, float baseValue)
	{
		return 0f;
	}
}
