using UnityEngine;

public class FirstTimeSystemPopupCamera : MonoBehaviour
{
	[SerializeField]
	private float mouseMoveDistance;

	[SerializeField]
	private float fadeDuration;

	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private GameObject activeImage;

	[SerializeField]
	private GameObject inActiveImage;

	private float mouseMoved;

	private Vector3 mousePos;

	private float currentFade;

	private void Update()
	{
	}
}
