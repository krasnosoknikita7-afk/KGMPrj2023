using System.Collections;

public class MaterialDescription
{
	public enum MaterialSpecialProperty
	{
		Burning = 0,
		Poisonous = 1,
		Slippery = 2,
		Bouncy = 3,
		Destructable = 4,
		Healing = 5,
		Lethal = 6,
		Speeding = 7,
		Slowing = 8,
		Crumbling = 9,
		Size = 10
	}

	public static readonly MaterialDescription[] materialDescriptions;

	private BitArray specialProperties;

	public string Name { get; private set; }

	public string Description { get; private set; }

	public BitArray SpecialProperties
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public MaterialDescription(string name, string description, params MaterialSpecialProperty[] specialProperties)
	{
	}
}
