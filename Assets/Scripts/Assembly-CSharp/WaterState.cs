using MV.Common;
using UnityEngine;

public class WaterState
{
	private const float suffocationDamage = 5f;

	private const float avatarHeight = 2.1f;

	private readonly AvatarModifierPackage.AvatarModifier[] additionalUnderWaterModifiers;

	private readonly float oxygenMax;

	private float oxygen;

	private Vector3 worldPosition;

	private bool hasGillsNoLungs;

	public WaterState(WorldObjectSkillDataManager skillDataManager)
	{
	}

	public void Destroy()
	{
	}

	public void Update(Vector3 worldPosition, MVInteractableBase avatarInteractable)
	{
	}

	private void UpdateModifiers(MVInteractableBase avatarInteractable)
	{
	}

	private void UpdateLocalAvatarOxygen(MVInteractableBase avatarInteractable)
	{
	}

	private float UnderwaterJumpPowerModifierCallback()
	{
		return 0f;
	}

	private float UnderwaterModifierCallback()
	{
		return 0f;
	}

	private float ComputeAvatarWaterProximity(Vector3 position)
	{
		return 0f;
	}

	private void OnAvatarModeChange(SpawnRoleModeType newSpawnRoleMode)
	{
	}
}
