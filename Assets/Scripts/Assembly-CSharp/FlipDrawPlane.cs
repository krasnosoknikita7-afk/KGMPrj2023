using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipDrawPlane : MonoBehaviour
{
	[SerializeField]
	private Color SelectedColor;

	[SerializeField]
	private Color NormalColor;

	[SerializeField]
	private Image XAxisImage;

	[SerializeField]
	private Image YAxisImage;

	[SerializeField]
	private Image ZAxisImage;

	private int currentIndex;

	private List<DrawPlaneAxis> drawPlaneAxises;

	private Image currentlySelectedImage;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void InitalizeImages()
	{
	}

	public void Flip()
	{
	}

	private void HighlightImages()
	{
	}
}
