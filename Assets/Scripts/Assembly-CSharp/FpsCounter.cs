using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
	private class FPSMetricCollector
	{
		private readonly float startTime;

		private const float timeBeforeMetricCollectionInSeconds = 30f;

		private bool metricsCollected;

		public bool IsFPSCollected => false;

		public bool IsTimeForCollect => false;

		public void CollectFPSMetric(float averageFPS)
		{
		}
	}

	private static FpsCounter instance;

	private int idx;

	private float[] frameTimes;

	private FPSMetricCollector metricsCollector;

	private float fps;

	public static float Fps => 0f;

	public static bool StartedPlaying { get; set; }

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	protected void Update()
	{
	}
}
public class FPSCounter : MonoBehaviour
{
	[SerializeField]
	private Text fpsText;

	private float frameUpdateRate;

	private float currTime;

	private void Update()
	{
	}
}
