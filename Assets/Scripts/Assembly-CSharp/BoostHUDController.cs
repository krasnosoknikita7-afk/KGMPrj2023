using System.Collections.Generic;
using GameMeterVisuals;
using UnityEngine;
using UnityEngine.UI;

public class BoostHUDController : MonoBehaviour
{
	[SerializeField]
	private HorizontalLayoutGroup content;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private SlideOnClick slideOnClick;

	[SerializeField]
	private BoostImageController boostImageController;

	[SerializeField]
	private int boosterWidth;

	private readonly List<GameObject> currentBoosts;

	private void Start()
	{
	}

	private void SetupHUD()
	{
	}

	private void SetupTransform()
	{
	}

	private void CreateActiveBoosts()
	{
	}

	private void OnDestroy()
	{
	}
}
