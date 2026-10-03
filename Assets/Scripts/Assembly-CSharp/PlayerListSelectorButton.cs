using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListSelectorButton : MonoBehaviour
{
	[SerializeField]
	private Image buttonImage;

	[SerializeField]
	public Button button;

	[SerializeField]
	private Text playerCount;

	[SerializeField]
	private Text score;

	[SerializeField]
	private Image teamImage;

	public void Initialize(MVTeam team)
	{
	}
}
