using System;
using System.Collections.Generic;
using UnityEngine;

public class SkinnedMeshOptimizer : MonoBehaviour
{
	[Serializable]
	private struct MeshData
	{
		public SkinnedMeshRenderer skinnedMesh;

		public MeshRenderer mesh;
	}

	[SerializeField]
	private List<MeshData> meshData;

	private SkinnedMeshOptimizeManager.SkinnedMeshOptimizationData optimizationData;

	private bool isEnabled;

	public void TurnOffMesh()
	{
	}

	public void DisableOptimizer()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
