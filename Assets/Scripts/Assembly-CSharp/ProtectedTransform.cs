using UnityEngine;

public class ProtectedTransform
{
	private readonly Transform transform;

	public Vector3 localPosition
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion localRotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 localScale
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public ProtectedTransform(Transform transform)
	{
	}
}
