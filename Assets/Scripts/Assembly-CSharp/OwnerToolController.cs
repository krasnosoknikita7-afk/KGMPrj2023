using UnityEngine;
using UnityEngine.UI;

public class OwnerToolController : MonoBehaviour
{
	[SerializeField]
	private Text playerName;

	[SerializeField]
	private Text text;

	public void Initialize(string playerNameString)
	{
	}

	public void OnKickClicked()
	{
	}

	private static MVPlayer GetPlayer(string userName)
	{
		return null;
	}
}
