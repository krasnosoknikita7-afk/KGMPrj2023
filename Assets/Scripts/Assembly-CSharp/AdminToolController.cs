using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminToolController : MonoBehaviour
{
	private struct DefaultBan
	{
		public string BanReason;

		public string BanDuration;

		public string BanDurationFormat;

		public DefaultBan(string reason, string duration, string format)
		{
			BanReason = null;
			BanDuration = null;
			BanDurationFormat = null;
		}
	}

	[SerializeField]
	private Dropdown presetBansDropdown;

	[SerializeField]
	private Dropdown banDurationMultiplier;

	[SerializeField]
	private Text playerName;

	[SerializeField]
	private InputField duration;

	[SerializeField]
	private InputField reason;

	[SerializeField]
	private Button ownerKickButton;

	private static readonly Dictionary<string, int> durationMultiplier;

	private static readonly Dictionary<string, DefaultBan> defaultBanLookup;

	public void Initialize(string playerNameString)
	{
	}

	public void OnBanClicked()
	{
	}

	public void OnKickClicked()
	{
	}

	public void OnRevokeEditRightsClicked()
	{
	}

	private void OnDefaultBanDropdownChanged(int option)
	{
	}

	private bool IsBanFieldsValid()
	{
		return false;
	}

	private static MVPlayer GetPlayer(string userName)
	{
		return null;
	}
}
