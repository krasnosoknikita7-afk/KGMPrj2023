using UnityEngine;

public class UseLeverObject : ObjectPrefab
{
	[SerializeField]
	private Collider leverCollider;

	[SerializeField]
	private Collider editCollider;

	[SerializeField]
	private UseInteractor useInteractor;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private Transform plateButtonTransform;

	[SerializeField]
	private GameObject visualRoot;

	public GameObject useInteractionRotator;

	public Collider LeverCollider => null;

	public Collider EditCollider => null;

	public UseInteractor UseInteractor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TriggerBoxEvents TriggerBoxEvents => null;

	public Transform PlateButtonTransform => null;

	public GameObject VisualRoot => null;

	protected override void OnValidate()
	{
	}
}
