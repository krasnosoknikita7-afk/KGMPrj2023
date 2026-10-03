using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusPopup : MonoBehaviour
{
	[SerializeField]
	private Text xpProgress;

	[SerializeField]
	private ProgressBarAndroid progressBar;

	[SerializeField]
	private float duration;

	private float currentTime;

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	private string FormatXP(float amount)
	{
		return null;
	}
}
