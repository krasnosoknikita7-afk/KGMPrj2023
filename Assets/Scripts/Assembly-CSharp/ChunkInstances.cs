using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.WorldObject;
using UnityEngine;

public class ChunkInstances : IEnumerator, IEnumerable
{
	public struct ChunkInstanceVariables
	{
		public GameObject gameObject;

		public BoxCollider collider;

		public MeshRenderer renderer;

		public MeshFilter filter;
	}

	private Dictionary<IntVector, ChunkInstanceVariables> chunkInstances;

	[CompilerGenerated]
	private EventHandler<ChunkInstancesChanged> m_Changed;

	public int Count => 0;

	public object Current => null;

	public event EventHandler<ChunkInstancesChanged> Changed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Add(IntVector intVector, ChunkInstanceVariables gameObject)
	{
	}

	public void Remove(IntVector intVector)
	{
	}

	public bool Contains(IntVector intVector)
	{
		return false;
	}

	public bool TryGetValue(IntVector intVector, out ChunkInstanceVariables gameObject)
	{
		gameObject = default;
		return false;
	}

	public ChunkInstanceVariables GetChunk(IntVector intVector)
	{
		return default;
	}

	public void Clear()
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}
}
