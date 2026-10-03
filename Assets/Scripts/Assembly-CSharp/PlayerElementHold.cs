using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerElementHold : MonoBehaviour
{
	[SerializeField]
	private Text playerName;

	[SerializeField]
	private Text rank;

	[SerializeField]
	private Text score;

	[SerializeField]
	private GameObject memberUI;

	[SerializeField]
	private Text memberRank;

	[SerializeField]
	private Image nonMemberUI;

	[SerializeField]
	private List<Image> backgrounds;

	[SerializeField]
	private Image redDot;

	public void Initialize(MVPlayer player, GameStatCounterType typeToDisplay, int scoreValue)
	{
	}

	public void UpdateScoreIndex()
	{
	}

	private void ActivateSubscriberUI(bool isFriend)
	{
	}
}
