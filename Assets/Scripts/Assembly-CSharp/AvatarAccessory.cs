using UnityEngine;

public abstract class AvatarAccessory : MonoBehaviour
{
	private Transform _transform;

	private Collider[] _colliders;

	private Renderer[] _renderers;

	private bool _visible;

	public abstract AccessorySettings AccessorySettings { get; }

	public string AssetPath { get; private set; }

	public float Offset { get; set; }

	public float Scale { get; set; }

	public Transform Transform => null;

	public Collider[] Colliders => null;

	public Renderer[] Renderers => null;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual Vector3 AttachmentPointWorldPos => default;

	public virtual bool HasAttachmentPoint => false;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public virtual Bounds GetWorldBounds()
	{
		return default;
	}

	public virtual Bounds GetLocalBounds()
	{
		return default;
	}

	public virtual void InitAccessory(string assetReqPath, string bundleName)
	{
	}
}
