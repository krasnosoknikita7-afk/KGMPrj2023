public class XPLevelLimits
{
	public int PrevXP { get; set; }

	public int NextXP { get; set; }

	public int Level { get; set; }

	public int XPNextRel => 0;

	public XPLevelLimits()
	{
	}

	public XPLevelLimits(int prevXp, int nextXp, int level)
	{
	}

	public int XpRel(int currentXp)
	{
		return 0;
	}

	public bool Validate(int currentXp)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
