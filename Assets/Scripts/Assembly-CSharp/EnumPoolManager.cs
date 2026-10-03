using System.Collections.Generic;
using UnityEngine;

public class EnumPoolManager : MonoBehaviour
{
	[SerializeField]
	private List<Pool> pool;

	private Pool[] lookupTable;

	private void Awake()
	{
	}

	public Pool GetPool(PoolEnums pEnum)
	{
		return null;
	}

	public T Instantiate<T>(PoolEnums pEnum) where T : MonoBehaviour
	{
		return null;
	}

	public void Return(MonoBehaviour obj, PoolEnums pEnum)
	{
	}
}
