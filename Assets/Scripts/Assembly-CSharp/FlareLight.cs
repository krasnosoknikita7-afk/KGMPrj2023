using UnityEngine;

public class FlareLight : MonoBehaviour
{
	[SerializeField]
	private Light light;

	[SerializeField]
	private LensFlare lensFlare;

	public Light Light => null;

	public LensFlare LensFlare => null;

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private void SetEnabled(bool b)
	{
	}

	protected void Reset()
	{
	}
}
