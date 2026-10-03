using UnityEngine;
using UnityEngine.UI;

public class DayNightCycleController : MonoBehaviour
{
	[Header("Dependencies")]
	[SerializeField]
	private Toggle playToggle;

	[SerializeField]
	private Image playImage;

	[SerializeField]
	private Image pauseImage;

	[SerializeField]
	private DayNightSlider slider;

	[SerializeField]
	private RectTransform trackFill;

	private DayNightCycle cycle;

	public void Initialize(DayNightCycle cycle)
	{
	}

	protected void Update()
	{
	}

	protected void OnDestroy()
	{
	}

	public void OnToggle(bool play)
	{
	}

	public void SetSimulationTime()
	{
	}

	private void UpdateTrackBackground()
	{
	}
}
