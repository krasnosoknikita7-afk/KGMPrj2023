using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ThemeImageUVScaler : MonoBehaviour
{
	[SerializeField]
	private RawImage image;

	private Rect prevRect;

	private RectTransform RectTransform => null;

	protected void Reset()
	{
	}

	private void Update()
	{
	}
}
