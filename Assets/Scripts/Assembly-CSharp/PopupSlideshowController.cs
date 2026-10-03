using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupSlideshowController : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> pages;

	private int currentPage;

	[SerializeField]
	private GameObject pageControls;

	[SerializeField]
	private GameObject pageRight;

	[SerializeField]
	private GameObject pageLeft;

	[SerializeField]
	private Text currentPageText;

	[SerializeField]
	private bool lastPageHasPageControls;

	public void Start()
	{
	}

	public void PageTurned(int dir)
	{
	}
}
