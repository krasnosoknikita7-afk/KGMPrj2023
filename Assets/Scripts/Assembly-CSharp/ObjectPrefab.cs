using UnityEngine;

public class ObjectPrefab : MonoBehaviour
{
	[SerializeField]
	protected Renderer[] meshRenderers;

	[SerializeField]
	protected Collider mainCollider;

	public Renderer[] MeshRenderers => null;

	public Collider Collider => null;

	protected virtual void OnValidate()
	{
	}
}
