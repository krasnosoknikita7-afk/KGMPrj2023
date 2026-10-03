using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class TeamTab : MonoBehaviour
{
	[SerializeField]
	private Text playerCount;

	[SerializeField]
	private Text score;

	[SerializeField]
	private Image teamImage;

	[SerializeField]
	private List<Image> darkTeamColoredImages;

	[SerializeField]
	private List<Image> teamColoredImages;

	public void Initialize(MVTeam team, GameStatCounterType statToDisplay)
	{
	}
}
