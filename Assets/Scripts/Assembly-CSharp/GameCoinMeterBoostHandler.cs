using UnityEngine;
using UnityEngine.UI;

public class GameCoinMeterBoostHandler : MonoBehaviour
{
	[SerializeField]
	private float ExpandAmount;

	[SerializeField]
	private LayoutElement elementToExpand;

	[SerializeField]
	private Text boostAmountText;

	private void Start()
	{
	}
}
