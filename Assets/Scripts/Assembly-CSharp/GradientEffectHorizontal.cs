using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradientEffectHorizontal : BaseMeshEffect
{
	public Color left;

	public Color right;

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void ModifyVertices(List<UIVertex> vertexList)
	{
	}

	private void SetVertexColor(List<UIVertex> vertexList, int index, Color color)
	{
	}
}
