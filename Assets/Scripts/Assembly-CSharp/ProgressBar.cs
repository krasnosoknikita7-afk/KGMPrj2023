using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	[SerializeField]
	private Scrollbar progressBar;

	private float progress;

	public float Progress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
