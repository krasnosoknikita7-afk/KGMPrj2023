using System.Collections.Generic;
using UnityEngine;

public class VehicleVisualizationBase : MonoBehaviour
{
	public List<GameObject> lodGameObjects;

	protected float disableVisualizationDistance;

	protected float cullDistance;

	protected bool isInSpawner;

	private bool disabledByLod;

	public virtual void ChangeLOD(float distance)
	{
	}

	protected static void ParentHullTransformToVisualizationRoot(Transform hullTransform, Transform visualizationRoot)
	{
	}
}
