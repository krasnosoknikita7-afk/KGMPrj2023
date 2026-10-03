using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeSystemPopupMovementHeight : MonoBehaviour
{
	[Serializable]
	private struct ControlImage
	{
		public KogamaControls key;

		public Image control;

		public GameObject checkMark;
	}

	[SerializeField]
	private List<ControlImage> controlImages;

	[SerializeField]
	private float fadeDuration;

	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private Color deactivated;

	private float currentFade;

	private bool IsFinished
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private void SetControl(KogamaControls control)
	{
	}
}
