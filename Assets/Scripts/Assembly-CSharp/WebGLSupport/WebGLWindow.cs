using System;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;

namespace WebGLSupport
{
	public static class WebGLWindow
	{
		[CompilerGenerated]
		private static Action m_OnFocusEvent;

		[CompilerGenerated]
		private static Action m_OnBlurEvent;

		[CompilerGenerated]
		private static Action m_OnResizeEvent;

		private static string ViewportContent;

		public static bool Focus { get; private set; }

		public static event Action OnFocusEvent
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

		public static event Action OnBlurEvent
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

		public static event Action OnResizeEvent
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

		static WebGLWindow()
		{
		}

		private static void Init()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowFocus()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowBlur()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowResize()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void RuntimeInitializeOnLoadMethod()
		{
		}
	}
}
