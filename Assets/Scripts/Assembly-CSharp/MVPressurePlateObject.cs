using UnityEngine;

public class MVPressurePlateObject : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private Transform plateModelTransform;

	[SerializeField]
	private PressurePlateTintObject tintObject;

	[SerializeField]
	private GameObject plateLogicModel;

	public GameObject useInteractionRotator;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public GameObject TriggerBoxLogic => null;

	public Transform PlateModelTranform => null;

	public PressurePlateTintObject TintObject => null;

	protected override void OnValidate()
	{
	}
}
