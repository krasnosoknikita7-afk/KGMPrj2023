using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundScroll : MonoBehaviour
{
	[SerializeField]
	private RawImage image;

	[SerializeField]
	private float Speed;

	[SerializeField]
	private Vector2 Direction;

	[SerializeField]
	private Vector2 Scale;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
