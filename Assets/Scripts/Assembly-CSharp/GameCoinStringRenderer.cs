using System.Collections.Generic;
using UnityEngine;

public class GameCoinStringRenderer : MonoBehaviour
{
	private struct PriceTagString
	{
		public Vector3 start;

		public Vector3 end;

		public Color color;
	}

	[SerializeField]
	private Material stringMaterial;

	private Queue<PriceTagString> strings;

	public void Start()
	{
	}

	public void AddString(Vector3 start, Vector3 end, Color color)
	{
	}

	private void OnPostRender()
	{
	}

	private void DrawString(PriceTagString s)
	{
	}
}
