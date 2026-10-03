using UnityEngine;
using UnityEngine.UI;

public class DamageArrow : MonoBehaviour
{
	[SerializeField]
	[Header("Dependencies")]
	private Image image;

	public Sprite Sprite
	{
		set
		{
		}
	}

	public RectTransform RectTransform => null;

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}
}
