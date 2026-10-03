using UnityEngine;

public class WindTurbineObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private Transform areaColliderTransform;

	[SerializeField]
	private Collider areaCollider;

	[SerializeField]
	private Collider editorCollider;

	[SerializeField]
	private ParticleSystem windParticleSystem;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	public GameObject VisualObject => null;

	public Transform AreaColliderTransform => null;

	public Collider AreaCollider => null;

	public Collider EditorCollider => null;

	public ParticleSystem WindParticleSystem => null;

	public TriggerBoxEvents TriggerBoxEvents => null;
}
