using UnityEngine;

public class SelectionBox : MonoBehaviour
{
	private MeshRenderer meshRenderer;

	private MeshFilter meshFilter;

	private float fadeOutTime;

	private float fadeOutBeginTime;

	private bool isFadingOut;

	private float fadeInTime;

	private float fadeInBeginTime;

	private bool isFadingIn;

	private float baseAlpha;

	private float currentAlpha;

	private void Start()
	{
	}

	public void Init(IModelingConstraint constraint, string layer = "UIItems")
	{
	}

	private void Update()
	{
	}

	public void FadeIn(float fadeInTime, Material material, Vector3[] corners)
	{
	}

	public void FadeOutDestroy(float fadeOutTime)
	{
	}

	private void OnDestroy()
	{
	}
}
