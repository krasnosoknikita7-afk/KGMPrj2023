using UnityEngine;
using UnityEngine.EventSystems;

public class LevelRewardsLobbyState : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private LevelRewardAnimation levelRewardAnimation;

	private bool isMouseOver;

	private static int previousNextLevelRewardShown;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void ShowRewards()
	{
	}

	private void ShowLevelNotification()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
