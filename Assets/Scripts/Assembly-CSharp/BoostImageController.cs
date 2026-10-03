using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostImageController : MonoBehaviour
{
	[Serializable]
	private struct BoosterImageDef
	{
		public BoostType type;

		public Image image;
	}

	[SerializeField]
	private List<BoosterImageDef> boosterImages;

	public Image GetBoostVisualization(BoostType type)
	{
		return null;
	}
}
