using UnityEngine;

public class GamePointChestModelController : MonoBehaviour
{
	public GameObject closedMesh;

	public GameObject openMesh;

	[SerializeField]
	private Animation openingAnimation;

	[SerializeField]
	private Renderer openingRenderer;

	[SerializeField]
	private GreyOutObjectScript greyOutScript;

	[SerializeField]
	private float fadeStartTime;

	[SerializeField]
	private float fadeEndTime;

	private bool shouldGreyOut;

	private bool isOpening;

	private float openingStartTime;

	public bool ShouldGreyOut
	{
		set
		{
		}
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Disable()
	{
	}

	public bool IsVisible()
	{
		return false;
	}

	private void Update()
	{
	}
}
