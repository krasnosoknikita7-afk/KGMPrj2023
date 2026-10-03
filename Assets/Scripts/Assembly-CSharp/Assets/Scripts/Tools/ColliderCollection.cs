using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Tools
{
	public class ColliderCollection : IEnumerable<Collider>, IEnumerable, IReadOnlyCollection<Collider>
	{
		private readonly LinkedList<Collider> colliders;

		private readonly Collider baseCollider;

		private Collider activeCollider;

		public int Count => 0;

		public Collider Base => null;

		public Collider Active => null;

		public ColliderCollection(Collider baseCollider)
		{
		}

		public void SetActiveCollider(Collider collider)
		{
		}

		public bool RemoveCollider(Collider collider)
		{
			return false;
		}

		IEnumerator<Collider> IEnumerable<Collider>.GetEnumerator()
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public void CopyTo(Array array, int index)
		{
		}
	}
}
