using UnityEngine;

public class ImpulseRay : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer rayRenderer;

	public float radius;

	public Color startColor;

	private const string tintColor = "_TintColor";

	private const float time = 0.4f;

	private readonly Color endColor;

	private float t;

	private float rayMagnitude;

	public MeshRenderer RayRenderer => null;

	public void Initialize(Vector3 target)
	{
	}

	private void Update()
	{
	}
}
