using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageAnimator : MonoBehaviour
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private Color startColor;

	[SerializeField]
	private Color endColor;

	[SerializeField]
	private AnimationCurve curve;

	[SerializeField]
	private float speed;

	private float time;

	public void SetColor(Color start, Color end)
	{
	}

	public float GetCurrentAlpha()
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
