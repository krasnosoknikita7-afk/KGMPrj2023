using MV.WorldObject;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class TeamSelectButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private Image buttonImage;

	[SerializeField]
	private Text teamName;

	[SerializeField]
	private Text playerCountText;

	[SerializeField]
	private Text friendCountText;

	[SerializeField]
	private GameObject friendIcon;

	private TeamData teamData;

	private UnityAction<MVTeam> OnTeamSelected;

	public void Initialize(TeamData teamData, UnityAction<MVTeam> OnTeamSelected)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void StartPlaying()
	{
	}
}
