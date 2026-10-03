using UnityEngine;

public struct MaterialHitPackage
{
	public AvatarModifierPackageType PackageType;

	public ParticleSystem ParticlePrefab;

	public MaterialHitPackage(AvatarModifierPackageType type, ParticleSystem prefab)
	{
		PackageType = AvatarModifierPackageType.None;
		ParticlePrefab = null;
	}
}
