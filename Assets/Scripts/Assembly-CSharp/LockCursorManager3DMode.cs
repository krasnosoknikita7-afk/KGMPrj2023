using System;
using UnityEngine;

public class LockCursorManager3DMode : MonoBehaviour, ILockCursorManager
{
	public Action<bool> OnCursorLockChanged { get; set; }

	public bool CursorLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CursorLockWithoutCallback
	{
		set
		{
		}
	}

	private static void CursorLog(string s)
	{
	}

	protected void OnApplicationFocus(bool focus)
	{
	}

	protected void LockCursor()
	{
	}

	protected void LockCursorWithoutCallback()
	{
	}

	protected void UnlockCursor()
	{
	}

	protected void UnlockCursorWithoutCallback()
	{
	}
}
