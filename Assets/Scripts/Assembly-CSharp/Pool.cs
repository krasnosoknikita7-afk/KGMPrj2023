using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pool
{
	[SerializeField]
	private MonoBehaviour prefab;

	[SerializeField]
	private int poolSize;

	[SerializeField]
	private PoolEnums poolEnum;

	private Transform parent;

	private List<int> available;

	private MonoBehaviour[] pool;

	public int ObjectsAvailable => 0;

	public PoolEnums PoolType => PoolEnums.CenterGunBullet;

	public MonoBehaviour Prefab => null;

	public MonoBehaviour Next => null;

	public MonoBehaviour Return
	{
		set
		{
		}
	}

	public T Instantiate<T>() where T : MonoBehaviour
	{
		return null;
	}

	public void ReturnObject(MonoBehaviour obj)
	{
	}

	public void Initialize(Transform parent)
	{
	}
}
