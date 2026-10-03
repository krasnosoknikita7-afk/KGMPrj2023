using UnityEngine;

public class OverrideMaterial : MonoBehaviour
{
	public float friction;

	public float bouncyness;

	public float softness;

	public float staticFriction;

	public float toughness;

	public string materialName;

	public string description;

	public string path;

	public MaterialSound materialSound;

	public AvatarModifierPackageType modifierPackageType;

	public int priceGold;

	public bool isUnlocked;

	public void Register()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
