using UnityEngine;

public class FirstTimeCubeEditFadeButtons : MonoBehaviour
{
	[SerializeField]
	private float fadeIn;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private float currentTime;

	private bool doFading;

	private void Awake()
	{
	}

	public void ActivateImmediate()
	{
	}

	public bool IsEnabled()
	{
		return false;
	}

	public void Activate()
	{
	}

	private void Update()
	{
	}
}
