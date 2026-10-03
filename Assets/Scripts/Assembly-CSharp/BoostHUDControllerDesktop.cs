using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostHUDControllerDesktop : MonoBehaviour
{
	[SerializeField]
	private HorizontalLayoutGroup content;

	[SerializeField]
	private BoostImageController boostImageController;

	private List<GameObject> currentBoosts;

	private void Start()
	{
	}

	private void CreateActiveBoosts()
	{
	}

	private void OnDestroy()
	{
	}
}
