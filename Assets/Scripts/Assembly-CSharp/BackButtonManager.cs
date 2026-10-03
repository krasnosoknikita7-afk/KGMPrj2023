using System.Collections.Generic;
using UnityEngine.Events;

public static class BackButtonManager
{
	private class BackButtonSubscriber
	{
		public BackButtonHandler handler;

		public KogamaControls button;

		public KeyState state;

		public UnityAction callback;

		public BackButtonSubscriber(BackButtonHandler handler, KogamaControls button, KeyState state, UnityAction callback)
		{
		}
	}

	private static List<BackButtonSubscriber> subscribers;

	public static void Update()
	{
	}

	public static void Subscribe(BackButtonHandler handler, KogamaControls button, KeyState state, UnityAction callback)
	{
	}

	public static void Unsubscribe(BackButtonHandler handler)
	{
	}

	public static void PostDestroyCleanup()
	{
	}

	private static bool ContainsHandler(BackButtonHandler handler)
	{
		return false;
	}
}
