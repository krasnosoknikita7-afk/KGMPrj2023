using UnityEngine;

public class ShootableButtonObject : ObjectPrefab
{
	[SerializeField]
	private Collider editCollider;

	[SerializeField]
	private GreyOutObjectScript greyOutObject;

	[SerializeField]
	private Collider targetCollider2D;

	[SerializeField]
	private Collider targetCollider3D;

	[SerializeField]
	private GameObject visualRoot;

	public Collider EditCollider => null;

	public Collider TargetCollider2D => null;

	public Collider TargetCollider3D => null;

	public GreyOutObjectScript GreyOutObject => null;

	public GameObject VisualRoot => null;

	protected override void OnValidate()
	{
	}
}
