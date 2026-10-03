using UnityEngine;

public class Blinker
{
	private Material blinkMaterial;

	private float blinkStartTime;

	private float blinkDuration;

	private float blinkInterval;

	public bool IsExpired => false;

	public Blinker(float interval, Material m, Color color)
	{
	}

	public void Start(float duration)
	{
	}

	public void Stop()
	{
	}

	public void Draw(Mesh mesh, Transform tfm, Camera targetCamera, int layerMask = 0)
	{
	}

	public void DestroyBlinkerMaterial()
	{
	}
}
