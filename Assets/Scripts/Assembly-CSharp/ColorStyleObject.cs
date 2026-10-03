using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Graphic))]
public class ColorStyleObject : MonoBehaviour
{
	[SerializeField]
	private Graphic graphic;

	[SerializeField]
	private ColorStyle imageStyle;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public void UpdateColorStyle(ColorStyle colorStyle)
	{
	}

	private void OnValidate()
	{
	}
}
