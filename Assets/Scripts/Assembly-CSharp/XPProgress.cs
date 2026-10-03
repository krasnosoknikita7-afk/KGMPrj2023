using MV.Common;
using UnityEngine.Networking;

public class XPProgress
{
	public delegate void OnXPProgressDataDelegate(XPProgressData xpProgress);

	public OnXPProgressDataDelegate OnXPProgressData;

	private XPProgressData xpProgressData;

	public XPProgressData XPProgressData => null;

	public int XP => 0;

	public XPProgress(MVLocalPlayer player, InitialLevelData initialLevelData)
	{
	}

	public void Update(int currentPlayerXP, XPRewardType xpId, int XPdelta, int memberCount)
	{
	}

	private void UpdateLevel(int level)
	{
	}

	public void Destroy()
	{
	}

	private void XPLimitsCallback(UnityWebRequest result)
	{
	}

	private void OnXPLevelLimitsUpdated(XPLevelLimits xpLevelLimits)
	{
	}
}
