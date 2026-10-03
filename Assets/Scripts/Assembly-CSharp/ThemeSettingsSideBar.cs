using UnityEngine;
using UnityEngine.UI;

public class ThemeSettingsSideBar : MonoBehaviour
{
	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private Image closeImage;

	[SerializeField]
	private Image backImage;

	public RectTransform Content => null;

	public void InitializeForPreview()
	{
	}
}
