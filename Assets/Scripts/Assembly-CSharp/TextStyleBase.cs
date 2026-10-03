using UnityEngine;
using UnityEngine.UI;

public abstract class TextStyleBase : MonoBehaviour
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private TextStyle textStyle;

	[SerializeField]
	private ColorStyle colorStyle;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}
}
