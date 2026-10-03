using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierUnlockedPopupContentTierTempUnlocked : TierUnlockedPopupContentBase
{
	[SerializeField]
	private Text tierRankText;

	public override void Initialize(GamePassTier unlockedGamePassTier, UnityAction onDisplayDoneCallback)
	{
	}
}
