using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierTempUnlockedInformationPopupContent : TierUnlockedPopupContentBase
{
	[SerializeField]
	private Text tempUnlockInformationText;

	private string tempUnlockInformation;

	public override void Initialize(GamePassTier unlockedGamePassTier, UnityAction onDisplayDoneCallback)
	{
	}
}
