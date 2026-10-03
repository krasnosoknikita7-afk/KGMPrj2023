using System.Collections.Generic;
using UnityEngine;

public class SkinnedMeshOptimizeManager : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public struct SkinnedMeshOptimizationData
	{
		public List<SkinnedMeshRenderer> skinnedMesh;

		public List<MeshRenderer> mesh;
	}

	private List<SkinnedMeshOptimizationData> optimizationDataList;

	private const int allowedSkinnedMeshAmount = 5;

	public void AddOptimizationData(SkinnedMeshOptimizationData optimizationData)
	{
	}

	public void RemoveoptimizationData(SkinnedMeshOptimizationData optimizationData)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	private bool IsNewMeshCloser(SkinnedMeshOptimizationData newMesh, List<SkinnedMeshOptimizationData> oldMeshes, out int index)
	{
		index = default;
		return false;
	}
}
