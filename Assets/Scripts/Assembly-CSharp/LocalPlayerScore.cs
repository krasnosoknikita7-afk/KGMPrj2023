using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class LocalPlayerScore : MonoBehaviour
{
	[SerializeField]
	private int scoreBoardCount;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Text playerNameText;

	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Text rankingText;

	[SerializeField]
	private GameObject memberUI;

	[SerializeField]
	private Text memberRankingText;

	[SerializeField]
	private GameStatCounterType statTypeToShow;

	public void Initialize()
	{
	}

	public void Activate()
	{
	}

	private int GetLocalPlayerRanking(GameStatCounterType statType, MVTeam localTeam, int localActorNumber, int localScore)
	{
		return 0;
	}

	private void Show(GameStatCounterType statType, MVTeam localTeam, int currentRanking, int localScore)
	{
	}
}
