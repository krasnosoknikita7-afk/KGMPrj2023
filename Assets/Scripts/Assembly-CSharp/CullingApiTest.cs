using System.Collections.Generic;
using UnityEngine;

public class CullingApiTest : MonoBehaviour
{
	private class TestClass : ICullingSubscriber
	{
		public int CullingIndex { get; set; }

		public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
		{
		}
	}

	private List<TestClass> testClasses;

	[SerializeField]
	private bool addBoundingSphere;

	[SerializeField]
	private bool unSubscribe;

	[SerializeField]
	private bool distancesChange;

	[SerializeField]
	private Transform movingTransform;

	private Camera mainCamera;

	private void Start()
	{
	}

	private void Subscribe()
	{
	}

	private void UnSubscribe()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
