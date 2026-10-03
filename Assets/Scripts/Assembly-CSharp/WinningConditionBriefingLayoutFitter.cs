using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningConditionBriefingLayoutFitter : MonoBehaviour
{
	[Serializable]
	private class LayoutGroupAspectFitterDef
	{
		public LayoutGroup layoutGroup;

		public LayoutElement group;

		public List<LayoutElement> elements;

		public float elementAspectRatio;
	}

	[SerializeField]
	private VerticalLayoutGroup layoutGroup;

	[SerializeField]
	private List<LayoutGroupAspectFitterDef> elements;

	[SerializeField]
	private float groupAspectRatio;

	private Vector2 desktopReferenceRes;

	private float defaultSpacing;

	private Vector2 referenceRes;

	private void Start()
	{
	}

	public void FixAspectRatio()
	{
	}

	private void AdjustElement(LayoutGroupAspectFitterDef layoutElement)
	{
	}
}
