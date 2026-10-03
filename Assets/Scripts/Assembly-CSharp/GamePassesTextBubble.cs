using UnityEngine;
using UnityEngine.UI;

public class GamePassesTextBubble : MonoBehaviour
{
	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private Text text;

	[SerializeField]
	private bool deactivateAfterFade;

	private bool isActive;

	public bool DeactivateAfterFade
	{
		set
		{
		}
	}

	public bool IsActive => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnFaderDone()
	{
	}

	public void Activate(string textBubbleText)
	{
	}
}
