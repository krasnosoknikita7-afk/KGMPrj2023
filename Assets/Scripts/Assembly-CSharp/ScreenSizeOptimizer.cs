using System;
using UnityEngine;

public class ScreenSizeOptimizer : MonoBehaviour
{
	[SerializeField]
	private Camera cam;

	private RenderTexture renderTarget;

	public static Vector2 originalSize;

	public static Action OnHalfResolution;

	private int minWidthInPixels;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	private void HalfResolution()
	{
	}

	public void SetResolution(int newWidth, int newHeight)
	{
	}

	public void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	public static void UpdateOriginalSizeIfNecessary()
	{
	}
}
