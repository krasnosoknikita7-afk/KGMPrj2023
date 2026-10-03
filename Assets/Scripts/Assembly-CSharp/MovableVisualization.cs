using System;
using System.Collections.Generic;
using UnityEngine;

public class MovableVisualization : MonoBehaviour, IUpdatecontrollerSubscriberFixedUpdate, IUpdatecontrollerSubscriberBase
{
	private class Package
	{
		public readonly Vector3 position;

		public readonly Quaternion rotation;

		public readonly float time;

		public Package(Vector3 position, Quaternion rotation)
		{
		}
	}

	private MVCubeModelBase cmb;

	private GameObject cmbClone;

	private Package next;

	private Package current;

	private Queue<Package> packages;

	private bool isVisible;

	private bool canBeVisible;

	private bool isDirty;

	private const float updateDirtyInterval = 1f;

	private float prevUpdateDirtyTime;

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

	protected virtual void Awake()
	{
	}

	public void Init(MVCubeModelBase cmb)
	{
	}

	private void cmb_Changed(CubeModelChangedEventArgs e)
	{
	}

	private static GameObject CreateMeshClone(MVCubeModelBase cmb)
	{
		return null;
	}

	private static void RemoveAllComponentsInChildrenExclude(Type[] exclude, GameObject gameObject)
	{
	}

	public void ChangeLOD(bool newVisible)
	{
	}

	private void SetMeshRenderers(bool enable, GameObject gameObject)
	{
	}

	private void Update()
	{
	}

	private void HandleDirty()
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}
}
