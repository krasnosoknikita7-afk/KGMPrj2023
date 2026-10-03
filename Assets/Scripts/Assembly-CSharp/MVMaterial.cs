using MV.WorldObject;
using UnityEngine;

public class MVMaterial
{
	public int unlockPriceGold;

	public bool isUnlocked;

	public Mesh Mesh { get; private set; }

	public string Name { get; private set; }

	public string Description { get; private set; }

	public PhysicalProperties PhysicalProperties { get; private set; }

	public AvatarModifierPackageType ModifierPackageType { get; private set; }

	public Texture2D ButtonTexture { get; private set; }

	public bool IsAvailable => false;

	public bool IsDestructible => false;

	public MVMaterial()
	{
	}

	public MVMaterial(int materialId, string name, string description, PhysicalProperties physicalProperties, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType, int priceGold, bool isUnlocked, MaterialButtonTextureGenerator materialButtonTextureGenerator)
	{
	}

	public MVMaterial(PhysicalProperties physicalProperties, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType)
	{
	}

	private void GenerateCube(int materialId)
	{
	}

	private void AddVertices(int direction)
	{
	}
}
