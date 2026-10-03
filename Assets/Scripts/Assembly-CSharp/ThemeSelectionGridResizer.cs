using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ThemeSelectionGridResizer : MonoBehaviour
{
	[SerializeField]
	private GridLayoutGroup grid;

	private float prevSize;

	private RectTransform RectTransform => null;

	protected void Update()
	{
	}
}
