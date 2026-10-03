using MV.Common;

public class XPProgressData
{
	private XPLevelLimits xpLevelLimits;

	private int playerCurrentXP;

	private XPRewardType xpId;

	private int memberCount;

	private int xpDelta;

	public XPLevelLimits XPLevelLimits
	{
		set
		{
		}
	}

	public int NextXP => 0;

	public int PrevXP => 0;

	public XPRewardType XpID
	{
		get
		{
			return XPRewardType.None;
		}
		set
		{
		}
	}

	public int XP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MemberCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string XPString => null;

	public int XPDelta
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int XpRel => 0;

	public int XpNextRel => 0;

	public bool XPLimitExceeded => false;

	public int Level => 0;

	public XPProgressData(int playerCurrentXP, XPLevelLimits xpLevelLimits)
	{
	}
}
