using UnityEngine;
using UnityEngine.UI;

public class FirstTimeEventPopupWithProgress : FirstTimeEventPopup
{
	[SerializeField]
	private Scrollbar ProgressBar;

	[SerializeField]
	private Text progressText;

	private float progress;

	private float interpolationSpeed;

	private float interpolateToSize;

	private float Progress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void SetProgress(float current, float max)
	{
	}

	private void Update()
	{
	}
}
