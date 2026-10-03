using System;
using System.Collections.Generic;
using UnityEngine;

public class TypePoolManager : MonoBehaviour
{
	[SerializeField]
	private List<Pool> pool;

	private Dictionary<Type, Pool> poolAsDictionary;

	private void Awake()
	{
	}

	public Pool GetPool<T>() where T : MonoBehaviour
	{
		return null;
	}

	public T Instantiate<T>() where T : MonoBehaviour
	{
		return null;
	}

	public void Return<T>(T obj) where T : MonoBehaviour
	{
	}

	private void Update()
	{
	}
}
