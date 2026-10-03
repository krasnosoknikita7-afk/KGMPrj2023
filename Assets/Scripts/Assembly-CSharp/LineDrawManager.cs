using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class LineDrawManager : MonoBehaviour
{
	private class LinkLine
	{
		public Vector3 startPos;

		public Vector3 endPos;

		public Color color;

		public LinkLine(Vector3 startPos, Vector3 endPos, Color color)
		{
		}
	}

	[SerializeField]
	private Material lineMaterial;

	private Link tempLink;

	private ObjectLink tempObjectLink;

	private LinkObjectScript tempLinkObject;

	private Queue<LinkLine> linkLines;

	protected void OnPostRender()
	{
	}

	public void SetTempLink(Link link)
	{
	}

	public void SetTempObjectLink(ObjectLink link)
	{
	}

	public void DrawLineDirect(Vector3 from, Vector3 to, Color color)
	{
	}

	private void DrawLine(Vector3 from, Vector3 to, Color color)
	{
	}

	private void DrawEnqueuedLines()
	{
	}

	private void DrawLine(LinkLine linkLine)
	{
	}
}
