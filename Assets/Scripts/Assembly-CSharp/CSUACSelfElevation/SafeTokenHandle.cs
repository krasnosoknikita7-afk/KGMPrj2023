using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CSUACSelfElevation
{
	internal class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private SafeTokenHandle()
			: base(ownsHandle: false)
		{
		}

		internal SafeTokenHandle(IntPtr handle)
			: base(ownsHandle: false)
		{
		}

		[PreserveSig]
		internal static extern bool CloseHandle(IntPtr handle);

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
