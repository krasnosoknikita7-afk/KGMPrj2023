using UnityEngine;

public class WaterSplashComponent : MonoBehaviour
{
	protected IMovable movingObject;

	protected Bounds bounds;

	private Vector3 offset;

	private int waterObjectID;

	public virtual void Initialize(IMovable obj)
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}
}
