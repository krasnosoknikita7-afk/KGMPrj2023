using System.Collections.Generic;
using UnityEngine;

public class InteractableMaterialHitHandler
{
	private Dictionary<AvatarModifierPackageType, ParticleSystem> particles;

	private AvatarModifierPackageType currentMoveHitParticleType;

	private ParticleSystem currentParticleSystem;

	private Vector3 prevPos;

	private const float deadzoneDist = 1f;

	public void Initialize(MaterialHitPackage[] packages, Transform parent)
	{
	}

	public void HandleHit(MVControllerColliderHit moveHit)
	{
	}

	private void DisableCurrentSystem()
	{
	}

	private void SetNewCurrentParticleSystem(AvatarModifierPackageType newParticleType)
	{
	}

	private void UpdateCurrentSystem(MVControllerColliderHit moveHit)
	{
	}

	private void SetParticlePlacement(Vector3 position, Vector3 eulerRotation)
	{
	}
}
