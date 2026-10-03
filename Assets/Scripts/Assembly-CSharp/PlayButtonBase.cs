using UnityEngine;
using UnityEngine.UI;

public class PlayButtonBase : MonoBehaviour
{
	[SerializeField]
	private Image countdownFill;

	[SerializeField]
	protected bool shouldPop;

	protected void UpdateButton()
	{
	}

	protected virtual void StartPlaying()
	{
	}

	protected virtual void OnCountDownEnd()
	{
	}
}
