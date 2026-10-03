using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gamestrap
{
	[AddComponentMenu("UI/Gamestrap UI/Gradient")]
	public class GradientEffect : BaseMeshEffect
	{
		public Color top;

		public Color bottom;

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
}
