using UnityEngine;
using UnityEngine.UI;

public class BoostNotificationDisplay : MonoBehaviour
{
	[SerializeField]
	private Text boostsActive;

	[SerializeField]
	private Image backgroundColor;

	[SerializeField]
	private Color boostActiveColor;

	[SerializeField]
	private Color boostInactiveColor;

	private void Start()
	{
	}

	private void OnBoostCountChanged()
	{
	}

	private void OnDestroy()
	{
	}
}
