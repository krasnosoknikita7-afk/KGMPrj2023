using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebriefingWinnerGUI : MonoBehaviour
{
	[Serializable]
	private struct WinningConditionData
	{
		public WinningConditionType ScoreType;

		public Image ScoreImage;

		public GameObject WinningConditionImage;

		public Text AdditionalInfo;

		public GameObject InfoBG;
	}

	[SerializeField]
	private Text winnerName;

	[SerializeField]
	private Text timer;

	[SerializeField]
	private Text winValue;

	[SerializeField]
	private RawImage winnerImage;

	[SerializeField]
	private ImageAnimator backgroundImage;

	[SerializeField]
	private List<WinningConditionData> winConImages;

	public void SetWinnerImage(Color startColor, RenderTexture image)
	{
	}

	public void SetAdditionalInformation(string text, WinningConditionType winConType)
	{
	}

	public void SetWinValue(string winVal)
	{
	}

	public void SetTimerText(string time)
	{
	}

	public void SetWinnerText(string winner)
	{
	}

	public void ActivateScoreImage(WinningConditionType statType)
	{
	}
}
