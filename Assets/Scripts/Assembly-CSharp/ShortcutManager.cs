using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ShortcutManager : MonoBehaviour, IShortcutKeyRegister, IEventSystemHandler, IShortcutKeyUnRegister
{
	private class ShortcutKey : IEquatable<ShortcutKey>
	{
		public readonly KogamaControls kogamaControl;

		public readonly KeyState keyState;

		public readonly UnityAction callback;

		public ShortcutKey(KogamaControls kogamaControl, KeyState keyState, UnityAction callback)
		{
		}

		public bool Equals(ShortcutKey other)
		{
			return false;
		}
	}

	private Dictionary<KogamaControls, Stack<ShortcutKey>> shortCutKeys;

	public void RegisterShortcutKey(KogamaControls kogamaControl, KeyState keyState, UnityAction callback)
	{
	}

	public void UnRegisterShortcutKey(KogamaControls kogamaControl, KeyState keyState)
	{
	}

	private void Update()
	{
	}
}
