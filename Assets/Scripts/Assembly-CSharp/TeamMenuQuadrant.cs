using UnityEngine;
using UnityEngine.UI;

public class TeamMenuQuadrant : MonoBehaviour
{
	private TeamData teamData;

	[SerializeField]
	private Text players;

	[SerializeField]
	private Text score;

	[SerializeField]
	private Image header;

	[SerializeField]
	private Image buttonImage;

	[SerializeField]
	private Image teamImage;

	public void Initialize(TeamData teamData)
	{
	}

	public void TeamSelected()
	{
	}
}
