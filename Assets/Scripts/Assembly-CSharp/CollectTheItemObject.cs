using UnityEngine;

public class CollectTheItemObject : ObjectPrefab
{
	[SerializeField]
	private Collider editCollider;

	[SerializeField]
	private RotateLocal rotator;

	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private GameObject cullingObject;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private GreyOutObjectScript greyOutObject;

	[SerializeField]
	private GreyOutObjectScript greyOutScriptEditMode;

	[SerializeField]
	private CollectTheItemBlinker blinker;

	private const float timeBeforeBlink = 3f;

	private float fadeTimer;

	public Collider EditCollider => null;

	public GameObject VisualObject => null;

	public GameObject CullingObject => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public RotateLocal RotateLocal => null;

	public GreyOutObjectScript GreyOutObject => null;

	public GreyOutObjectScript GreyOutScriptEditMode => null;

	public CollectTheItemBlinker Blinker => null;

	public bool EnableFading
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private bool ShouldDoBlinking()
	{
		return false;
	}

	public void InitializeGreyOutScript()
	{
	}

	protected override void OnValidate()
	{
	}
}
