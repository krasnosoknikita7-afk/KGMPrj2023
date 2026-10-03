using System.Collections.Generic;
using MV.WorldObject;

public class MVMaterialRepository
{
	private readonly List<MVMaterial> materials;

	private readonly MVMaterial noMaterial;

	private readonly MVMaterial inAirMaterial;

	private readonly PhysicalProperties physicalPropertiesDefault;

	public const int DEFAULT_MATERIAL_ID = 21;

	public bool allowDestructibleMaterialSelection;

	private static MVMaterialRepository instance;

	public int MaterialCount => 0;

	public MVMaterial InAirMaterial => null;

	public static bool AllowDestructibleMaterialSelection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Reset()
	{
	}

	public void SetMaterialPrice(int materialID, int materialUnlockPriceGold)
	{
	}

	public void SetMaterialUnlocked(int materialId, bool unlocked)
	{
	}

	private bool AllMaterialUnlocked()
	{
		return false;
	}

	public void AddMaterial(string name, string description, string path, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType, int priceGold, bool isUnlocked, float[] physicalProperties, MaterialButtonTextureGenerator materialButtonTextureGenerator)
	{
	}

	public MVMaterial GetMaterial(byte materialId)
	{
		return null;
	}

	public PhysicalProperties GetMaterialPhysicalProperties(byte materialId)
	{
		return default;
	}

	public bool IsMaterialUnlocked(byte[] mats)
	{
		return false;
	}

	public bool IsMaterialUnlocked(byte mat)
	{
		return false;
	}
}
