using UnityEngine;
using UnityEngine.UI;

public class TabMenuButton : TabMenuButtonBase
{
	[SerializeField]
	private Text buttonText;

	[SerializeField]
	private Button button;

	public override void Initialize(int tabId, string categoryName)
	{
	}

	public override void SetAsSelected()
	{
	}

	public override void SetAsDeselected()
	{
	}
}
